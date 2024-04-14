using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Constants;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class ReviewServiceTest
    {
        private IReviewService reviewService;
        private ISerieService serieService;
        private IMovieService movieService;
        private IRepository repository;
        private SqliteConnection connection;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var mockLogger = new Mock<ILogger<ReviewService>>();
            var mockSerieLogger = new Mock<ILogger<SerieService>>();
            var mockMovieLogger = new Mock<ILogger<MovieService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            serieService = new SerieService(mockSerieLogger.Object, repository);
            movieService = new MovieService(mockMovieLogger.Object, repository);
            reviewService = new ReviewService(mockLogger.Object, repository, movieService, serieService);
        }

        [Test]
        public async Task GetReviewByIdTest()
        {
            var reviewId = 67;

            var review = await reviewService.GetReviewById(reviewId);

            Assert.That(review.ReviewId, Is.EqualTo(reviewId), "GetReviewById method did not return expected results!");
        }
        [Test]
        public async Task CreateMovieReviewAsync()
        {
            var showType = "movie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 1;

            await reviewService.CreateAsync(review, userId, movieId, showType);

            var repositoryCount = repository.TakeAll<Review>().Count();

            Assert.That(repositoryCount, Is.EqualTo(3), "Review was not created succesfully!");

        }
        [Test]
        public async Task CreateMovieReviewAsyncCorrectly()
        {
            var showType = "movie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 1;

            await reviewService.CreateAsync(review, userId, movieId, showType);

            var repositoryCount = repository.TakeAll<MovieReview>().Count();

            Assert.That(repositoryCount, Is.EqualTo(2), "MovieReview was not created succesfully!");

        }
        [Test]
        public async Task DidCreateMovieReviewAsyncReturnMovieId()
        {
            var showType = "movie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 1;

            var createdId = await reviewService.CreateAsync(review, userId, movieId, showType);

            Assert.That(createdId, Is.EqualTo(1), "Return id was not correct!");
        }
        [Test]
        public void CreateMovieReviewAsyncIfMovieIsNull()
        {
            var showType = "movie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 44;

            Assert.ThrowsAsync<NullReferenceException>(async () => await reviewService.CreateAsync(review,userId,movieId,showType), MessagesConstants.ShowDoesNotExsistsMessage);
        }
        [Test]
        public async Task CreateSerieReviewAsync()
        {
            var showType = "serie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 1;

            await reviewService.CreateAsync(review, userId, serieId, showType);

            var repositoryCount = repository.TakeAll<Review>().Count();

            Assert.That(repositoryCount, Is.EqualTo(3), "Review was not created succesfully!");
        }
        [Test]
        public async Task CreateSerieReviewAsyncCorrectly()
        {
            var showType = "serie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 1;

            await reviewService.CreateAsync(review, userId, serieId, showType);

            var repositoryCount = repository.TakeAll<SerieReview>().Count();

            Assert.That(repositoryCount, Is.EqualTo(2), "SerieReview was not created succesfully!");
        }
        [Test]
        public async Task DidCreateSerieReviewAsyncReturnMovieId()
        {
            var showType = "serie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 1;

            var createdId = await reviewService.CreateAsync(review, userId, serieId, showType);

            Assert.That(createdId, Is.EqualTo(1), "Return id was not correct!");
        }
        [Test]
        public void CreateSerieReviewAsyncSerieIsNull()
        {
            var showType = "serie";
            var review = DatabaseConstants.CreateReview();
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 44;

            Assert.ThrowsAsync<NullReferenceException>(async () => await reviewService.CreateAsync(review, userId, serieId, showType), MessagesConstants.ShowDoesNotExsistsMessage);
        }
        [Test]
        public async Task ReviewEditAsyncTest()
        {
            var reivewId = 67;
            var reviewToEdit = DatabaseConstants.ReviewForEdit();

            await reviewService.EditAsync(reivewId, reviewToEdit);

            var editedReview = await repository.GetByIdAsync<Review>(reivewId);

            Assert.That(editedReview.Content, Is.EqualTo(reviewToEdit.Content), "EditAsync method did not return expected results!");
        }
        [Test]
        public void ReivewEditAsyncIfMovieNullTest()
        {
            var reivewId = 4;
            var reviewToEdit = DatabaseConstants.ReviewForEdit();

            Assert.ThrowsAsync<NullReferenceException>(async () => await reviewService.EditAsync(reivewId, reviewToEdit), MessagesConstants.ReviewDoesNotExistsMessage);
        }
        [Test]
        public async Task ReivewDeleteAsyncTest()
        {
            var reivewId = 67;
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";

            await reviewService.DeleteAsync(reivewId, userId);

            var review = await repository.GetByIdAsync<Review>(reivewId);

            Assert.IsNull(review, "DeleteAsync dont delete what was expected!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}

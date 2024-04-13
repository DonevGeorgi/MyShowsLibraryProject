using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddingFinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "f545a72d-4969-4cfc-a7de-8c41e283010a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e01b48e-aaa4-4a29-b10b-02231fba6cd0", "AQAAAAEAACcQAAAAECvSUvxpqPpXzxRnYXmIGrtovtRJ+2U8TGgdlNryH3wJKw9O9NBZ9ewIDNWw4n8rhg==", "b1cb7b4b-007e-465d-98e2-fc639097847e" });

            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "CrewId", "Biography", "Birthdate", "MoreInfo", "Name", "Nationality", "PictureUrl", "Pseudonyms" },
                values: new object[,]
                {
                    { 7, "British actress Emilia Clarke was born in London and grew up in Oxfordshire, England. Her father was a theatre sound engineer and her mother is a businesswoman. Her father was working on a theatre production of \"Show Boat\" and her mother took her along to the performance. This is when, at the age of 3, her passion for acting began. From 2000 to 2005, she attended St. Edward's School of Oxford, where she appeared in two school plays. She went on to study acting at the prestigious Drama Centre London, where she took part in 10 plays. During this time, Emilia first appeared on television with a guest role in the BBC soap opera Doctors (2000).\r\n\r\nIn 2010, after graduating from the Drama Centre London, Emilia got her first film role in the television movie Triassic Attack (2010). In 2011, her breakthrough role came in when she replaced fellow newcomer Tamzin Merchant on Game of Thrones (2011) after the filming of the original pilot episode. From March to April 2013, she played Holly Golightly in a Broadway production of \"Breakfast at Tiffany's\". She played Sarah Connor in Terminator Genisys (2015), opposite Arnold Schwarzenegger, Jai Courtney and Jason Clarke. She played the lead role of Louisa Clark in the romantic comedy blockbuster Me Before You (2016) and went on to star in Solo: A Star Wars Story (2018) as Qi'ra.\r\n\r\nSince her rise to prominence, Emilia has contributed to various charitable organisations. In 2018, she was named as the ambassador to the Royal College of Nursing because of her efforts in raising awareness about the working condition of the nurses in the UK. In 2019, she was named as the first ambassador for the global Nursing Now campaign. In 2019, in a personal essay published in The New Yorker, Emilia revealed that she had suffered from two life threatening brain aneurysms in 2011 and 2013. She launched her own charity SameYou in 2019, which aims to broaden neurorehabilitation access for young people after a brain injury or stroke.", "23 Oct 1986", "https://en.wikipedia.org/wiki/Emilia_Clarke", "Emilia Clarke", "British", "https://th.bing.com/th/id/OIP.jQ8W5xuSZtGGDRKkKa1IGgHaKs?rs=1&pid=ImgDetMain", "Milly" },
                    { 8, "Peter Dinklage is an American actor. Since his breakout role in The Station Agent (2003), he has appeared in numerous films and theatre plays. Since 2011, Dinklage has portrayed Tyrion Lannister in the HBO series Game of Thrones (2011) . For this he won an Emmy for Outstanding Supporting Actor in a Drama Series and a Golden Globe Award for Best Supporting Actor - Series, Miniseries or Television Film in 2011.\r\n\r\nPeter Hayden Dinklage was born in Morristown, New Jersey, to Diane (Hayden), an elementary school teacher, and John Carl Dinklage, an insurance salesman. He is of German, Irish, and English descent. In 1991, he received a degree in drama from Bennington College and began his career. ", "11 Jun 1969", "https://en.wikipedia.org/wiki/Peter_Dinklage", "Peter Dinklage", "American", "https://th.bing.com/th/id/R.acf3c43e277f14048800c509b4949b5a?rik=stTnKvBHKvrKEg&pid=ImgRaw&r=0", "" },
                    { 9, "John was born as John Bradley West in 1988. Brought up in Wythenshawe, South Manchester, he attended St Paul's High School and Loreto College, Hulme before going on to Manchester Metropolitan University from where he graduated in 2010 with a B.A. degree in acting. It was via his college website that he obtained his first big television role in the epic fantasy series 'Game of Thrones (2011)' though he has since moved nearer home to appear in 'Shameless (2004)'. He is also an accomplished drummer and has experience in stand up comedy.", "15 Sep 1988", "https://en.wikipedia.org/wiki/John_Bradley_(English_actor)", "John Bradley", "English", "https://th.bing.com/th/id/R.e552352f327cdff6d0633b8342b58a55?rik=0K3o%2f3tBxmB%2bfg&pid=ImgRaw&r=0", "" },
                    { 10, "Irish actor Liam Cunningham was an electrician in the mid-'80s. He saw an ad for an acting school and he decided to give it a try. His first film role was as a policeman in \"Into the West.\" Since then, he has been involved in many films and theater productions on both sides of the Atlantic.", "02 Jun 1961", "https://en.wikipedia.org/wiki/Liam_Cunningham", "Liam Cunningham", "Irish", "https://ipravda.sk/res/2019/04/15/thumbs/herec-liam-cunningham-nestandard1.jpg", "" }
                });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "PosterUrl",
                value: "https://i.pinimg.com/originals/46/91/59/469159fbaa4eb301dbdc7717d823cd7a.jpg");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7,
                column: "PosterUrl",
                value: "https://img.buzzfeed.com/buzzfeed-static/static/2019-05/10/8/enhanced/buzzfeed-prod-web-03/enhanced-14778-1557491500-1.jpg");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8,
                column: "PosterUrl",
                value: "https://th.bing.com/th/id/R.3eb701872d74385c16cf27b11f08b8b3?rik=RltDJccLs1%2bT9A&pid=ImgRaw&r=0");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateOfRelease", "Duration", "ForMoreSummaryUrl", "OriginalAudioLanguage", "PosterUrl", "Summary", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 2, "14 Mar 1972", 175, "https://en.wikipedia.org/wiki/The_Godfather", "English", "https://media.posterlounge.com/img/products/710000/707663/707663_poster.jpg", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "The Godfather", "https://www.youtube.com/embed/UaVTIH8mujA?si=nO7BYx5S4L8-CYZk" },
                    { 3, "14 Jun 2008", 152, "https://en.wikipedia.org/wiki/The_Dark_Knight", "English", "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "The Dark Knight", "https://www.youtube.com/embed/EXeTwQWrcwY?si=d59GNM5M9oKK3tlv" },
                    { 4, "10 Sep 1999", 139, "https://en.wikipedia.org/wiki/Fight_Club", "English", "https://img.peliplat.com/api/resize/v1?imagePath=std/202202/6/b/6baf78ae0fc42ca861b7fcc908fe7c82.jpg", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "Fight Club", "https://www.youtube.com/embed/SUXWAEX2jlg?si=Ij-le8G1Vt-9xT8l" },
                    { 5, "08 Jul 2010", 148, "https://en.wikipedia.org/wiki/Inception", "English", "https://www.scope.dk/shared/39/204/syncopy-inception_400x600c.jpg", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", "Inception", "https://www.youtube.com/embed/YoHD9XEInc0?si=_NbDbg1IoSGsPppZ" },
                    { 6, "22 Sep 1995", 127, "https://en.wikipedia.org/wiki/Seven_(1995_film)", "English", "https://vistapointe.net/images/se7en-wallpaper-11.jpg", "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", "Se7en", "https://www.youtube.com/embed/znmZoVkCjpI?si=3THi5wYLOiRpBgA7" },
                    { 7, "26 Oct 2014", 169, "https://en.wikipedia.org/wiki/Interstellar_(film)", "English", "https://consequence.net/wp-content/uploads/2014/11/interstellar.png?resize=768", "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.", "Interstellar", "https://www.youtube.com/embed/zSWdZVtXT7E?si=_bQcYaqCJw9DuzxO" },
                    { 8, "16 Oct 2009", 118, "https://en.wikipedia.org/wiki/Law_Abiding_Citizen", "English", "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p3632501_p_v8_ao.jpg", "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free.", "Law Abiding Citizen", "https://www.youtube.com/embed/LX6kVRsdXW4?si=z4JvIvrRC-OC07ZZ" },
                    { 9, "30 May 2023", 140, "https://en.wikipedia.org/wiki/Spider-Man:_Across_the_Spider-Verse", "English", "https://tickets.imagix.be/system/images/posters/000/000/905/medium.jpg?1684928515", "Miles Morales catapults across the multiverse, where he encounters a team of Spider-People charged with protecting its very existence. When the heroes clash on how to handle a new threat, Miles must redefine what it means to be a hero.", "Spider-Man: Across the Spider-Verse", "https://www.youtube.com/embed/cqGjhVJWtEg?si=I6najQbKn348h0Av" },
                    { 10, "20 Jun 2001", 125, "https://en.wikipedia.org/wiki/Spirited_Away", "Japanese", "https://m.media-amazon.com/images/M/MV5BMjlmZmI5MDctNDE2YS00YWE0LWE5ZWItZDBhYWQ0NTcxNWRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches and spirits, and where humans are changed into beasts.", "Spirited Away", "https://www.youtube.com/embed/ByXuk9QqQkk?si=qym82LBRSX9w_0Vd" },
                    { 11, "01 May 2000", 155, "https://en.wikipedia.org/wiki/Gladiator_(2000_film)", "English", "https://m.media-amazon.com/images/M/MV5BMDliMmNhNDEtODUyOS00MjNlLTgxODEtN2U3NzIxMGVkZTA1L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Gladiator", "https://www.youtube.com/embed/P5ieIbInFpg?si=Vrd2Zatk6M3ichNU" },
                    { 12, "15 Jun 1994", 88, "https://en.wikipedia.org/wiki/The_Lion_King", "English", "https://lumiere-a.akamaihd.net/v1/images/p_thelionking_19752_1_0b9de87b.jpeg?region=0%2C0%2C540%2C810", "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", "The Lion King", "https://www.youtube.com/embed/lFzVJEksoDY?si=FkT-KFkh8eehzta_" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "EpisodesInSeason", "PosterUrl", "SeasonNumeration", "SeriesId", "YearOfRelease" },
                values: new object[,]
                {
                    { 2, "10", "https://game-of-thrones.io/Resources/Assets/images/cover-ss02.webp", 2, 1, "2012" },
                    { 3, "10", "https://image.tmdb.org/t/p/original/5MkZjRnCKiIGn3bkXrXfndEzqOU.jpg", 3, 1, "2013" },
                    { 4, "10", "https://cdn.europosters.eu/image/1300/art-photo/game-of-thrones-season-4-key-art-i135464.jpg", 4, 1, "2014" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "SeriesId", "ForMoreSummaryUrl", "OriginalAudioLanguage", "PosterUrl", "Summary", "Title", "TrailerUrl", "YearOfEnd", "YearOfStart" },
                values: new object[,]
                {
                    { 2, "https://en.wikipedia.org/wiki/Daredevil_(TV_series)", "English", "https://i.ebayimg.com/images/g/4roAAOSwU-pXtiYt/s-l1600.jpg", "A blind lawyer by day, vigilante by night. Matt Murdock fights the crime of New York as Daredevil.", "Daredevil", "https://www.youtube.com/embed/jAy6NJ_D5vU?si=bipQvQKvZA5weoWd", "2018", "2015" },
                    { 3, "https://en.wikipedia.org/wiki/3_Body_Problem_(TV_series)", "English", "https://dnm.nflximg.net/api/v6/2DuQlx0fM4wd1nzqm5BFBi6ILa8/AAAAQZlc5jetJ-D7HB82kd0QKhDPoQtVo0ez6AgsRBt7WnoqCe1NMdjNxuZPe5fQVeMXvQAvlZTQwo5NL_M2xhpfNikQkyynm0hjIpAEJ63kaCMD7tpb7DE2GyspOeL_u8idcYLvtb0c6_XMzHCqScBJNLW6.jpg?r=c4c", "A fateful decision made in 1960s China reverberates in the present, where a group of scientists partner with a detective to confront an existential planetary threat.", "3 Body Problem", "https://www.youtube.com/embed/mogSbMD6EcY?si=waJ7TQKmX5OsPE02", "", "2024" },
                    { 4, "https://en.wikipedia.org/wiki/The_Flash_(2014_TV_series)", "English", "https://hips.hearstapps.com/digitalspyuk.cdnds.net/14/35/ustv-the-flash-poster.jpg", "After being struck by lightning, Barry Allen wakes up from his coma to discover he's been given the power of super speed, becoming the Flash, and fighting crime in Central City.", "The Flash", "https://www.youtube.com/embed/IgVyroQjZbE?si=PxdjkywdsIYAOKPv", "2023", "2014" },
                    { 5, "https://en.wikipedia.org/wiki/Breaking_Bad", "English", "https://images.genius.com/9cb7e19233ebb2693a005c8621504c34.1000x1000x1.jpg", "A chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine with a former student in order to secure his family's future.", "Breaking Bad", "https://www.youtube.com/embed/HhesaQXLuRY?si=R-ATc5J-7f8YlAJT", "2013", "2008" },
                    { 6, "https://en.wikipedia.org/wiki/Sherlock_(TV_series)", "English", "https://m.media-amazon.com/images/M/MV5BMWEzNTFlMTQtMzhjOS00MzQ1LWJjNjgtY2RhMjFhYjQwYjIzXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg", "The quirky spin on Conan Doyle's iconic sleuth pitches him as a \"high-functioning sociopath\" in modern-day London. Assisting him in his investigations: Afghanistan War vet John Watson, who's introduced to Holmes by a mutual acquaintance.", "Sherlock", "https://www.youtube.com/embed/IrBKwzL3K7s?si=rwD1zOXk1yJgpwNn", "2017", "2010" },
                    { 7, "https://en.wikipedia.org/wiki/Black_Mirror", "English", "https://www.revue-etudes.com/prod/file/etudes/article/picture/2946.jpg", "Featuring stand-alone dramas -- sharp, suspenseful, satirical tales that explore techno-paranoia -- \"Black Mirror\" is a contemporary reworking of \"The Twilight Zone\" with stories that tap into the collective unease about the modern world.", "Black Mirror", "https://www.youtube.com/embed/5jY1ecibLYo?si=jaL2j2czFEXQT8oL", "", "2011" },
                    { 8, "https://en.wikipedia.org/wiki/The_Last_of_Us_(TV_series)", "English", "https://m.media-amazon.com/images/M/MV5BZGUzYTI3M2EtZmM0Yy00NGUyLWI4ODEtN2Q3ZGJlYzhhZjU3XkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_.jpg", "After a global pandemic destroys civilization, a hardened survivor takes charge of a 14-year-old girl who may be humanity's last hope.", "The Last of Us", "https://www.youtube.com/embed/uLtkt8BonwM?si=7lVv06Q_ZAV7c8Au", "", "2023" },
                    { 9, "https://en.wikipedia.org/wiki/Peaky_Blinders_(TV_series)", "English", "https://m.media-amazon.com/images/M/MV5BZjYzZDgzMmYtYjY5Zi00YTk1LThhMDYtNjFlNzM4MTZhYzgyXkEyXkFqcGdeQXVyMTE5NDQ1MzQ3._V1_.jpg", "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.", "Peaky Blinders", "https://www.youtube.com/embed/X3PGOaEfCmQ?si=lpU4Q_3Hy1v0uZqH", "2022", "2013" },
                    { 10, "https://en.wikipedia.org/wiki/Stranger_Things", "English", "https://resizing.flixster.com/0xxuABVVuzJrUT130WFHKE-irEg=/ems.cHJkLWVtcy1hc3NldHMvdHZzZWFzb24vNzUyMTFhOTktZTU4Ni00ODkyLWJlYjQtZTgxYTllZmU2OGM0LmpwZw==", "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supernatural forces and one strange little girl.", "Stranger Things", "https://www.youtube.com/embed/b9EkMc79ZSU?si=mRkshg9SYuYkdtYy", "2025", "2016" },
                    { 11, "https://en.wikipedia.org/wiki/House_(TV_series)", "English", "https://m.media-amazon.com/images/M/MV5BMDA4NjQzN2ItZDhhNC00ZjVlLWFjNTgtMTEyNDQyOGNjMDE1XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg", "Using a crack team of doctors and his wits, an antisocial maverick doctor specializing in diagnostic medicine does whatever it takes to solve puzzling cases that come his way.", "House", "https://www.youtube.com/embed/MczMB8nU1sY?si=AqO4vj535nUmLTRg", "2012", "2004" },
                    { 12, "https://en.wikipedia.org/wiki/Westworld_(TV_series)", "English", "https://m.media-amazon.com/images/M/MV5BZDg1OWRiMTktZDdiNy00NTZlLTg2Y2EtNWRiMTcxMGE5YTUxXkEyXkFqcGdeQXVyMTM2MDY0OTYx._V1_.jpg", "At the intersection of the near future and the reimagined past, waits a world in which every human appetite can be indulged without consequence.", "Westworld", "https://www.youtube.com/embed/9BqKiZhEFFw?si=p2zuNikDGCptxPAT", "2022", "2016" }
                });

            migrationBuilder.InsertData(
                table: "CrewRole",
                columns: new[] { "CrewId", "RoleId" },
                values: new object[,]
                {
                    { 7, 3 },
                    { 7, 4 },
                    { 8, 3 },
                    { 8, 4 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 3 },
                    { 10, 4 }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "EpisodeNumeration", "PosterUrl", "ReleaseDate", "SeasonId", "SeasonNumber", "Summary" },
                values: new object[,]
                {
                    { 11, 1, "https://images.cdn.prd.api.discomax.com/2023/02/09/e12b0dce-4721-3764-a31b-c216f26d70d8.jpeg?f=jpg&q=75&w=1280", "01 Apr 2012", 2, 2, "Tyrion arrives at King's Landing to take his father's place as Hand of the King. Stannis Baratheon plans to take the Iron Throne for his own. Robb tries to decide his next move in the war. The Night's Watch arrive at the house of Craster." },
                    { 12, 2, "https://advancelocal-adapter-image-uploads.s3.amazonaws.com/image.nj.com/home/njo-media/width2048/img/entertainment_impact_tv/photo/game-of-thrones-season-two-2-hbo-jon-snow-beyond-the-walljpg-2aa8494941b27aed.jpg", "08 Apr 2012", 2, 2, "Arya makes friends with Gendry. Tyrion tries to take control of the Small Council. Theon arrives at his home, Pyke, in order to persuade his father into helping Robb with the war. Jon tries to investigate Craster's secret." },
                    { 13, 3, "https://images.cdn.prd.api.discomax.com/2023/02/09/587b66d8-ab0b-3ac7-ab7c-58582fdcfd2a.jpeg?f=jpg&q=75&w=1280", "15 Apr 2012", 2, 2, "Tyrion tries to see who he can trust in the Small Council. Catelyn visits Renly to try and persuade him to join Robb in the war. Theon must decide if his loyalties lie with his own family or with Robb." },
                    { 14, 4, "https://images.cdn.prd.api.discomax.com/2023/02/09/6e978756-92fd-3b3b-a377-b9c64d3e6760.jpeg?f=jpg&q=75&w=1280", "22 Apr 2012", 2, 2, "Lord Baelish arrives at Renly's camp just before he faces off against Stannis. Daenerys and her company are welcomed into the city of Qarth. Arya, Gendry, and Hot Pie find themselves imprisoned at Harrenhal." },
                    { 15, 5, "https://m.media-amazon.com/images/M/MV5BMWE0NjQ0MDQtM2E1Zi00MmRmLWI1NTUtNjJjMjQxMjY1Y2QxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg", "29 Apr 2012", 2, 2, "Tyrion investigates a secret weapon that King Joffrey plans to use against Stannis. Meanwhile, as a token for saving his life, Jaqen H'ghar offers to kill three people that Arya chooses." },
                    { 16, 6, "https://m.media-amazon.com/images/M/MV5BNDEyNDg1MzA4Ml5BMl5BanBnXkFtZTcwMDY4MTc3Nw@@._V1_.jpg", "06 May 2012", 2, 2, "Theon seizes control of Winterfell. Jon captures a wildling, named Ygritte. The people of King's Landing begin to turn against King Joffrey. Daenerys looks to buy ships to sail for the Seven Kingdoms." },
                    { 17, 7, "https://wallup.net/wp-content/uploads/2016/05/02/43210-Game_of_Thrones-Daenerys_Targaryen-Jorah_Mormont-748x421.jpg", "13 May 2012", 2, 2, "Bran and Rickon have escaped Winterfell. Theon tries to hunt them down. Daenerys' dragons have been stolen. Jon travels through the wilderness with Ygritte as his prisoner. Sansa has bled and is now ready to have Joffrey's children." },
                    { 18, 8, "https://m.media-amazon.com/images/M/MV5BM2FiNmM4OWItMmM5Yi00ODAwLWE5YTUtZGRmMmIyZTAwMDkxXkEyXkFqcGdeQXVyMjg2MTMyNTM@._V1_.jpg", "20 May 2012", 2, 2, "Stannis is just days from King's Landing. Tyrion prepares for his arrival. Jon and Qhorin are taken prisoner by the wildlings. Catelyn is arrested for releasing Jaime. Arya, Gendry, and Hot Pie plan to escape from Harrenhal." },
                    { 19, 9, "https://i.ytimg.com/vi/p-W8l3E4NVw/maxresdefault.jpg", "27 May 2012", 2, 2, "Stannis Baratheon's fleet and army arrive at King's Landing and the battle for the city begins. Cersei plans for her and her children's future." },
                    { 20, 10, "https://images.cdn.prd.api.discomax.com/2023/02/09/9093fc33-7da9-3f45-a644-7953fe96e7ec.jpeg?f=jpg&q=75&w=1280", "03 Jun 2012", 2, 2, "Joffrey puts Sansa aside for Margaery Tyrell. Robb marries Talisa Maegyr. Jon prepares to meet Mance Rayder. Arya says farewell to Jaqen H'ghar. Daenerys tries to rescue her dragons." },
                    { 21, 1, "https://images.cdn.prd.api.discomax.com/2023/02/09/53532aa4-1284-3b32-84fe-b1931862c929.jpeg?f=jpg&q=75&w=1280", "31 May 2013", 3, 3, "Jon is brought before Mance Rayder, the King Beyond the Wall, while the Night's Watch survivors retreat south. In King's Landing, Tyrion asks for his reward. Littlefinger offers Sansa a way out." },
                    { 22, 2, "https://m.media-amazon.com/images/M/MV5BMjAyNzk5NDQwNl5BMl5BanBnXkFtZTcwMTkxNTcyOQ@@._V1_.jpg", "07 Apr 2013", 3, 3, "Bran and company meet Jojen and Meera Reed. Arya, Gendry, and Hot Pie meet the Brotherhood. Jaime travels through the wilderness with Brienne. Sansa confesses her true feelings about Joffery to Margaery." },
                    { 23, 3, "https://m.media-amazon.com/images/M/MV5BMjA4ODQxNDEzMV5BMl5BanBnXkFtZTcwNjM4MzA0OQ@@._V1_.jpg", "14 Apr 2013", 3, 3, "Robb and Catelyn arrive at Riverrun for Lord Hoster Tully's funeral. Tywin names Tyrion the new Master of Coin. Arya says goodbye to Hot Pie. The Night's Watch returns to Craster's. Brienne and Jaime are taken prisoner." },
                    { 24, 4, "https://m.media-amazon.com/images/M/MV5BMTQ3MzEzMjA1Ml5BMl5BanBnXkFtZTcwMTcyMTEwOQ@@._V1_.jpg", "21 Apr 2013", 3, 3, "Jaime mopes over his lost hand. Cersei is growing uncomfortable with the Tyrells. The Night's Watch is growing impatient with Craster. Daenerys buys the Unsullied." },
                    { 25, 5, "https://images.cdn.prd.api.discomax.com/2023/02/09/03803cf5-f1b5-368c-8c9a-be2cb70a4b18.jpeg?f=jpg&q=75&w=1280", "28 Apr 2013", 3, 3, "Robb's army is falling apart. Jaime reveals a story, to Brienne, that he has never told anyone. Jon breaks his vows. The Hound is granted his freedom. The Lannisters hatch a new plan." },
                    { 26, 6, "https://images.cdn.prd.api.discomax.com/2023/02/09/b0394adf-ca5e-3c46-b0cc-116931c56aae.jpeg?f=jpg&q=75&w=1280", "05 May 2013", 3, 3, "Jon and the wildlings scale the Wall. The Brotherhood sells Gendry to Melisandre. Robb does what he can to win back the Freys. Tyrion tells Sansa about their engagement." },
                    { 27, 7, "https://m.media-amazon.com/images/M/MV5BMTQwMjQ1Njg5N15BMl5BanBnXkFtZTcwNzE1MjE1OQ@@._V1_.jpg", "12 May 2013", 3, 3, "Jon and the wildlings travel south of the Wall. Talisa tells Robb that she's pregnant. Arya runs away from the Brotherhood. Daenerys arrives at Yunkai. Jaime leaves Brienne behind at Harrenhal." },
                    { 28, 8, "https://m.media-amazon.com/images/M/MV5BMzQ3NTgzNDUyN15BMl5BanBnXkFtZTcwNjAxODk1OQ@@._V1_.jpg", "19 May 2013", 3, 3, "Daenerys tries to persuade the Second Sons to join her against Yunkai. Stannis releases Davos from the dungeons. Sam and Gilly are attacked by a White Walker. Sansa and Tyrion wed." },
                    { 29, 9, "https://m.media-amazon.com/images/M/MV5BMTU3OTc2MTAxNF5BMl5BanBnXkFtZTcwODMxNDM2OQ@@._V1_.jpg", "02 Jun 2013", 3, 3, "Robb and Catelyn arrive at the Twins for the wedding. Jon is put to the test to see where his loyalties truly lie. Bran's group decides to split up. Daenerys plans an invasion of Yunkai." },
                    { 30, 10, "https://images.cdn.prd.api.discomax.com/2023/02/09/06d0f8ac-742c-3ae9-8938-479c759756ba.jpeg?f=jpg&q=75&w=1280", "09 Jun 2013", 3, 3, "Bran and company travel beyond the Wall. Sam returns to Castle Black. Jon says goodbye to Ygritte. Jaime returns to King's Landing. The Night's Watch asks for help from Stannis." },
                    { 31, 1, "https://m.media-amazon.com/images/M/MV5BMTA2NTk0OTY5MjdeQTJeQWpwZ15BbWU4MDk1MjUyNTEx._V1_.jpg", "06 Apr 2014", 4, 4, "Tyrion welcomes a guest to King's Landing. At Castle Black, Jon stands trial. Daenerys is pointed to Meereen, the mother of all slave cities. Arya runs into an old enemy." },
                    { 32, 2, "https://m.media-amazon.com/images/M/MV5BNTE5ZjRkODItZDVmZi00MzY2LWE5OGEtZjBmMmY4MTQ1OTdkXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg", "13 Apr 2014", 4, 4, "Joffrey and Margaery's wedding has come. Tyrion breaks up with Shae. Ramsay tries to prove his worth to his father. Bran and company find a Weirwood tree." },
                    { 33, 3, "https://images.cdn.prd.api.discomax.com/2023/02/09/0a6306ca-cd2a-3fa6-aca2-486de26c4a20.jpeg?f=jpg&q=75&w=1280", "20 Apr 2014", 4, 4, "Tyrion is arrested for murder and awaits trial. Sansa escapes King's Landing. Sam sends Gilly to Mole's Town as the Night's Watch finds itself in a tight spot. Meereen challenges Daenerys." },
                    { 34, 4, "https://media.vanityfair.com/photos/535a7973e8628ff16b000216/master/w_2560%2Cc_limit/760000_got_mp_092013_ep404-4912%255B1%255D.jpg", "27 Apr 2014", 4, 4, "Jaime entrusts a task to Brienne. Daenerys frees Meereen. Jon is given permission to lead a group of Night's Watchmen to Craster's Keep. Bran and company are taken hostage." },
                    { 35, 5, "https://imageio.forbes.com/blogs-images/erikkain/files/2014/06/game-of-thrones-s4e5-arya.png?format=png&height=600&width=1200&fit=bounds", "04 May 2014", 4, 4, "Tommen is crowned King of the Seven Kingdoms. Cersei builds her case against Tyrion. Sansa and Lord Baelish arrive at the Eyrie. The Night's Watch attacks Craster's Keep." },
                    { 36, 6, "https://m.media-amazon.com/images/M/MV5BMTUxMjIwMjYyMV5BMl5BanBnXkFtZTgwNTE2OTg3MTE@._V1_.jpg", "11 May 2014", 4, 4, "Tyrion's trial has come. Yara and her troops storm the Dreadfort to free Theon. Daenerys meets Hizdar zo Loraq. Stannis makes a deal with the Iron Bank of Braavos." },
                    { 37, 7, "https://i.pinimg.com/736x/b7/ed/6c/b7ed6c179e1582f3f776891fbf088a88.jpg", "18 May 2014", 4, 4, "Tyrion tries to find a champion. Daenerys sleeps with Daario. The Hound becomes wounded. Jon's advice is ignored at Castle Black. Brienne and Podrick receive a tip on Arya's whereabouts." },
                    { 38, 8, "https://thatshelf.com/wp-content/uploads/2014/06/Game-of-Thrones-Season-4-Episode-8-Viper-and-Mountain.jpg", "01 Jun 2014", 4, 4, "Theon helps Ramsay seize Moat Cailin. The wildlings attack Mole's Town. Sansa comes up with a story to protect Lord Baelish. Daenerys finds out a secret about Jorah Mormont. Oberyn Martell faces Gregor Clegane, the Mountain." },
                    { 39, 9, "https://hips.hearstapps.com/digitalspyuk.cdnds.net/14/24/tv-game-of-thrones-jon-snow-s04e09.jpg", "08 Jun 2014", 4, 4, "The battle between the Night's Watch and the wildlings has come." },
                    { 40, 10, "https://images.cdn.prd.api.discomax.com/2023/02/09/13a327af-12e2-377e-9d3f-360756f8cd1a.jpeg?f=jpg&q=75&w=1280", "15 Jun 2014", 4, 4, "Jon makes an important decision. Daenerys experiences new consequences. Brienne and Podrick have an unexpected encounter. Bran achieves a goal, while Tyrion makes an important discovery." }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "EpisodesInSeason", "PosterUrl", "SeasonNumeration", "SeriesId", "YearOfRelease" },
                values: new object[,]
                {
                    { 5, "13", "https://s3.thcdn.com/productimg/960/960/11312344-1464426542292674.jpg", 1, 2, "2015" },
                    { 6, "8", "https://images-na.ssl-images-amazon.com/images/I/81cB9M7ZLwL._AC_SL1200_.jpg", 1, 10, "2016" },
                    { 7, "9", "https://assets.exclaim.ca/image/upload/strangerthings2_2.jpg", 2, 10, "2017" },
                    { 8, "08", "https://res.cloudinary.com/jerrick/image/upload/c_crop,fl_progressive,h_630,q_auto,w_1200/xulbxvddyuexuzcdv3yt.jpg", 1, 3, "2024" }
                });

            migrationBuilder.InsertData(
                table: "SeriesCrews",
                columns: new[] { "CrewId", "SerieId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 9, 3 },
                    { 10, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CrewRole",
                keyColumns: new[] { "CrewId", "RoleId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "c3e5ab60-7376-45ab-a951-8c054ba57c49");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b221b4-dcf0-4f89-a7c0-9e930c87a789", "AQAAAAEAACcQAAAAELl2LtfEDUOxTY8uv+8dQiG1n2hIEV3cRdMOyBZBgkidz272HXcijYhb4hqbZ2Bs4g==", "cfb49ab8-3a9b-4584-b6ff-cbedc63acf77" });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "PosterUrl",
                value: "https://static.wikia.nocookie.net/gameofthrones/images/4/48/Thrones_S01E05.jpg/revision/latest?cb=20220918160258");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7,
                column: "PosterUrl",
                value: "https://static.wikia.nocookie.net/gameofthrones/images/7/79/Daenerys_and_Jorah_2x08.jpg/revision/latest/scale-to-width-down/560?cb=20120524205729");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8,
                column: "PosterUrl",
                value: "https://static.wikia.nocookie.net/gameofthrones/images/0/0c/Thrones_S01E08.jpg/revision/latest?cb=20220918160919");
        }
    }
}

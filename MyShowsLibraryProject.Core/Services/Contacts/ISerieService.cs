﻿using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISerieService
    {
        Task<IEnumerable<SerieInfoServiceModel>> GetAllReadonlyAsync();
        Task<SerieQueryServiceModel> GetAllCardInfoAsync(string? searchTerm, BaseSorting sorting, int currPage, int seriePerPage);
        Task<SeriesDetailsServiceModel> GetSerieDetailsByIdAsync(int serieId);
        Task<int> CreateAsync(SerieFormModel model);
        Task EditAsync(int serieId, SerieFormModel serie);
        Task DeleteAsync(int serieId);
        Task<bool> IsSeriePresent(int serieId);
    }
}

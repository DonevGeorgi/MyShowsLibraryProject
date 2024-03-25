﻿using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISerieService
    {
        Task<IEnumerable<SerieInfoServiceModel>> GetAllReadonlyAsync();
        Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllCardInfoAsync();
        Task<SeriesDetailsServiceModel> GetSerieDetailsByIdAsync(int serieId);
        Task<int> CreateAsync(SerieFormModel model);
        Task<bool> IsSeriePresent(int serieId);
    }
}
﻿using DevTubeCommerce.Application.Contract.Dto.Catalog;

namespace DevTubeCommerce.Application.Contract.Interfaces.Catalog;

public interface IFeatureService
{
    Task<List<FeatureDto>> GetAll();
    Task<FeatureDto> GetById(Guid id);
    Task Add(FeatureDto model);
    Task Edit(FeatureDto model);
    Task Remove(Guid id);

}

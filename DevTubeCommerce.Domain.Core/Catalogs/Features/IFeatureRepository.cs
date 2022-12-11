﻿namespace DevTubeCommerce.Domain.Core.Catalogs.Features;

public interface IFeatureRepository
{
    Task<FeatureId> Insert(Feature feature);
    Task Update(Feature feature);
    Task<Feature?> GetById(FeatureId featureId);
    void Delete(FeatureId featureId);
}

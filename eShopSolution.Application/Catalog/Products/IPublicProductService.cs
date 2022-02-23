﻿using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}

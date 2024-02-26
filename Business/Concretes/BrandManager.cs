﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;
public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    //kullanıcıdan veri istiyoruz ve karşılığında ihtiyacı olanı veriyoruz.
    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //business rules

        //mapping --> automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate=DateTime.Now;

        _brandDal.Add(brand);
        //mapping
        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.Id = 4;
        createdBrandResponse.CreatedDate=brand.CreatedDate;
        
        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        throw new NotImplementedException();
    }
}

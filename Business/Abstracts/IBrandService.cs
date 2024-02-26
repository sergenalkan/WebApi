﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    CreateBrandResponse Add(CreateBrandRequest brand);
    List<Brand> GetAll();
}

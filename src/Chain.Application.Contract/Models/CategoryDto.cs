﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain.Application.Models;

namespace Chain.Application.Contract.Models
{
    public record CategoryDto(string Title, int LimitOrder);
    public record CategoryShowProductsDto(string Title, int LimitOrder,IEnumerable<ProductDto> Products);
}

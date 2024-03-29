﻿//
//  Copyright 2022  Copyright Soluciones Modernas 10x
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System.Collections.Generic;
using Dev10x.BasicTaxonomy.Dtos;

namespace Dev10x.BasicTaxonomy.Interfaces
{
    /// <summary>
    /// Interface for Taxonomy Services
    /// </summary>
    public interface ITaxonomyService
    {
        /// <summary>
        /// Find All Taxonomy data
        /// </summary>
        /// <returns>List of TaxonomyDto</returns>
        List<TaxonomyDto> FindAll();
    }
}


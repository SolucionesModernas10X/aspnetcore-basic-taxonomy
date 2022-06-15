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

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dev10x.BasicTaxonomy.Models
{
    [Table("datamart", Schema = "taxonomy")]
    [Keyless]
    public class DatamartView
    {

        [Column("family_id")]
        public int FamilyId { get; set; }

        [Column("family_name")]
        public string FamilyName { get; set; }

        [Column("genus_id")]
        public int? GenusId { get; set; }

        [Column("genus_name")]
        public string GenusName { get; set; }

        [Column("specie_id")]
        public int? SpecieId { get; set; }

        [Column("specie_name")]
        public string SpecieName { get; set; }

    }
}


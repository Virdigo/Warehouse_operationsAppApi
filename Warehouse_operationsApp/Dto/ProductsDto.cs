﻿namespace Warehouse_operationsApp.Dto
{
    public class ProductsDto
    {
        public int id_Product { get; set; }
        public string Name { get; set; }
        public string vendor_code { get; set; }
        public int Price { get; set; }
        public int id_product_type { get; set; }
        public int id_unit { get; set; }
    }
}

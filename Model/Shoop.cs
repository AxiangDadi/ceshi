//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shoop
    {
        public int ShoopID { get; set; }
        public int GoodsID { get; set; }
        public string GoodsName { get; set; }
        public Nullable<int> ShoopCount { get; set; }
        public Nullable<decimal> GoodsPrice { get; set; }
        public string Descript { get; set; }
        public string UserName { get; set; }
        public string GoodsPic { get; set; }
    }
}

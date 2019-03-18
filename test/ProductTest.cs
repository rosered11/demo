using System;
using System.Collections.Generic;
using DemoApp.Business.TheProduct;
using Xunit;

namespace DemoAppTest
{
    public class ProductTest
    {
        [Fact]
        public void ProductFilterColorBlue_IsSuccess()
        {
            var productFilter = new ProductFilter();
            var colorSpecify = new ColorSpecification(Color.Blue);
            var data = new List<ProductManage>(){
                new ProductManage("P1",Color.Blue,Size.Large,1200),
                new ProductManage("P2",Color.Yellow,Size.Large,1200)
            };

            var listDatas = productFilter.Filter(data,colorSpecify);

            foreach(var checkData in listDatas){
                Assert.Equal(Color.Blue,checkData.color);
            }
        }
        [Fact]
        public void ProductFilterColorBlack_IsFail()
        {

        }
    }
}

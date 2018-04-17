using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtyIntegrations.com.n11CategoryService.api;
using BtyIntegrations.com.n11CityService.api;

namespace BtyIntegrations
{
    public class n11Service
    {
        public List<SubCategory> GetTopLevelCategories()
        {
            var authentication = new Authentication();
            authentication.appKey = "e2a9be17-8473-4efb-9e53-e29d87e0368b";
            authentication.appSecret = "O6PInuTZN0z1QZsn";

            GetTopLevelCategoriesRequest request = new GetTopLevelCategoriesRequest();
            request.auth = authentication;

            CategoryServicePortService port = new CategoryServicePortService();
            GetTopLevelCategoriesResponse topTopLevelCategoriesResponse = port.GetTopLevelCategories(request);
            List<SubCategory> categoryList = topTopLevelCategoriesResponse.categoryList.ToList();

            return categoryList;
            
        }

        public List<SubCategoryData> GetSubCategories(long cid)
        {
            var authentication = new Authentication();
            authentication.appKey = "e2a9be17-8473-4efb-9e53-e29d87e0368b";
            authentication.appSecret = "O6PInuTZN0z1QZsn";

            GetSubCategoriesRequest request = new GetSubCategoriesRequest();
            request.auth = authentication;
            request.categoryId = cid;            

            CategoryServicePortService port = new CategoryServicePortService();
            GetSubCategoriesResponse response = port.GetSubCategories(request);
            List<SubCategoryData> categoryList = response.category.ToList();

            return categoryList;

        }

        public void getCityList()
        {
            var authentication = new Authentication();
            authentication.appKey = "e2a9be17-8473-4efb-9e53-e29d87e0368b";
            authentication.appSecret = "O6PInuTZN0z1QZsn";
            GetCitiesRequest request = new GetCitiesRequest();


            CityServicePortService port = new CityServicePortService();
            GetCitiesResponse getCitiesResponse = port.GetCities(request);
            List<CityData> cityList = getCitiesResponse.cities.ToList();
            

        }

    }
}

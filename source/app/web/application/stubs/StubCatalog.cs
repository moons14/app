using System;
using System.Collections.Generic;
using System.Linq;
using app.web.application.catalogbrowsing;

namespace app.web.application.stubs
{
  public class StubCatalog : IFetchStoreInformation
  {
    public IEnumerable<Department> get_the_main_departments()
    {
        Department main_department = new Department();
        List<Department> main_department_list = new List<Department>();

        main_department.parentdepartmentID = -1;


        main_department.departmentID = 1;
        main_department.name = "House Hold";

        main_department_list.Add(main_department);

        main_department.departmentID = 2;
        main_department.name = "Men's Wear";

        main_department_list.Add(main_department);

        main_department.departmentID = 3;
        main_department.name = "Smelly Things";

        main_department_list.Add(main_department);

        main_department.departmentID = 4;
        main_department.name = "Women's Wear";

        main_department_list.Add(main_department);

        return main_department_list;

       //turn Enumerable.Range(1, 1000).Select(x => new Department {name = x.ToString("Department 0")});
    }

    public IEnumerable<Department> get_the_departments_using(ViewSubDepartmentsRequest request)
    {

        List<Department> main_departments = request.departments.ToList();
        List<Department> sub_departments = new List<Department>();
        Department sub_department = new Department();


        switch (main_departments[0].departmentID)
        {
            case 1:  // Household
                break;
            case 2: // Men's Wear
                sub_department.parentdepartmentID = 2;

                sub_department.departmentID = 5;
                sub_department.name = "Men's Shirts";

                sub_departments.Add(sub_department);

                sub_department.departmentID = 6;
                sub_department.name = "Men's Pants";

                sub_departments.Add(sub_department);

                sub_department.departmentID = 7;
                sub_department.name = "Men's Underwear";

                sub_departments.Add(sub_department);
                break;
            case 3:  // Smelly Things
                break;
            case 4:  // Women's Wear
                sub_department.parentdepartmentID = 4;

                sub_department.departmentID = 8;
                sub_department.name = "Women's Shirts";

                sub_departments.Add(sub_department);

                sub_department.departmentID = 9;
                sub_department.name = "Women's Pants";

                sub_departments.Add(sub_department);

                sub_department.departmentID = 10;
                sub_department.name = "Women's Dresses";

                sub_departments.Add(sub_department);

                sub_department.departmentID = 11;
                sub_department.name = "Women's Other";

                sub_departments.Add(sub_department);

                break;

            default:  // Anything Else,there is nothing
                break;
        }

            return sub_departments;
        
        //return Enumerable.Range(1, 5).Select(x => new Department { name = x.ToString("Sub Department 0") });
    }

    public IEnumerable<Product> get_the_products_using(ViewProductsInDepartmentRequest inputModel)
    {

        IList<Department> department = inputModel.department.ToList();
        List<Product> products = new List<Product>();
        Product product = new Product();


        switch (department[0].departmentID)
        {
            case 1:  // Household
                product.departmentID = 1;

                product.name = "Wine Glasses";
                product.description = "Long Stemmed Crystal Wine Glasses";
                product.price = Convert.ToDecimal("10.99") ;
                product.quantity = 10;

                products.Add(product);

                product.name = "Chopping Block";
                product.description = "Solid Wood Chopping Block";
                product.price = Convert.ToDecimal("55.76");
                product.quantity = 2;

                products.Add(product);

                product.name = "Waffle Maker";
                product.description = "Belgium Waffle Maker";
                product.price = Convert.ToDecimal("120.00");
                product.quantity = 3;

                products.Add(product);

                product.name = "Kid's Snow Shovel";
                product.description = "Kid's Snow Shovel.  For Kids";
                product.price = Convert.ToDecimal("12.99");
                product.quantity = 76;

                products.Add(product);


                break;
            case 3:  // Smelly Things
                product.departmentID = 3;

                product.name = "Lu Lu Lovely Cologne";
                product.description = "Cologne for the working programmer";
                product.price = Convert.ToDecimal("9.99");
                product.quantity = 7;

                products.Add(product);

                product.name = "Garbage Perfume";
                product.description = "Smell like you just came home from the dump";
                product.price = Convert.ToDecimal("335.99");
                product.quantity = 3;

                products.Add(product);

                product.name = "Vanilla Candle";
                product.description = "24 inch high candle of Love";
                product.price = Convert.ToDecimal("33.89");
                product.quantity = 10;

                products.Add(product);
                
                break;
            case 5:  // Men's Shirts
                product.departmentID = 5;

                product.name = "Tank Top";
                product.description = "White Tank Top With Pocket in Front";
                product.price = Convert.ToDecimal("9.99");
                product.quantity = 3;

                products.Add(product);

                product.name = "Dress Shirt";
                product.description = "Purple and Pink Dress Shirt With Don Cherry Collar";
                product.price = Convert.ToDecimal("55.99");
                product.quantity = 13;

                products.Add(product);


                product.name = "Hoodie";
                product.description = "New York Yankees Hoodie with a Hood";
                product.price = Convert.ToDecimal("45.00");
                product.quantity = 6;

                products.Add(product);


                
                break;
            case 6:  // Men's Pants
                product.departmentID = 6;

                product.name = "Jeans";
                product.description = "What else do you need.";
                product.price = Convert.ToDecimal("87.98");
                product.quantity = 331;

                products.Add(product);

                break;
            case 7:  // Men's Underwear
                product.departmentID = 7;

                product.name = "Tighty Whities";
                product.description = "The all purpose underwear.  5 pack.  All in White";
                product.price = Convert.ToDecimal("20.0");
                product.quantity = 15;

                products.Add(product);

                product.name = "Boxer";
                product.description = "Knee length boxers with happy face on the butt";
                product.price = Convert.ToDecimal("12.00");
                product.quantity = 9;

                products.Add(product);

                
                break;
            case 8:  // Women's Shirts
                product.departmentID = 8;

                product.name = "Frilly Long Sleeve";
                product.description = "White Frilly shrit with long sleeves";
                product.price = Convert.ToDecimal("19.99");
                product.quantity = 4;

                products.Add(product);

                product.name = "Women's Tank Top";
                product.description = "Multi colored tank tops";
                product.price = Convert.ToDecimal("14.99");
                product.quantity = 12;

                products.Add(product);

                product.name = "Silk Blouse";
                product.description = "Silk Blouse with buttons";
                product.price = Convert.ToDecimal("49.99");
                product.quantity = 5;

                products.Add(product);

                break;
            case 9:  // Women's Pants
                product.departmentID = 9;

                product.name = "Jeams";
                product.description = "Regular Fit Dark Blue Jeans";
                product.price = Convert.ToDecimal("59.99");
                product.quantity = 4;

                products.Add(product);
                
                product.name = "Yoga Pants";
                product.description = "Lu Lu Lemon Yoga pants";
                product.price = Convert.ToDecimal("89.99");
                product.quantity = 6;

                products.Add(product);
                
                
                
                break;
            case 10:  // Women's Dresses
                product.departmentID = 10;

                product.name = "Floor Length Dress";
                product.description = "Long flowing dress with bird pattern";
                product.price = Convert.ToDecimal("79.99");
                product.quantity = 6;

                products.Add(product);
                
                product.name = "Knee Length Dress";
                product.description = "Knee Length pleated dress";
                product.price = Convert.ToDecimal("39.99");
                product.quantity = 8;

                products.Add(product);
                
                product.name = "Mini-Skirt";
                product.description = "Not really a dress but still pretty cool";
                product.price = Convert.ToDecimal("3.99");
                product.quantity = 20;

                products.Add(product);

                
                break;
            case 11:  // Women's Other
                product.departmentID = 11;

                product.name = "Panty Hose";
                product.description = "Uh.  Panty Hose.  I am not sure what else to say";
                product.price = Convert.ToDecimal("9.99");
                product.quantity = 11;

                products.Add(product);

                product.name = "Hat";
                product.description = "Big Hat with lots of fake fruit in it.  Awesome for any occasion.";
                product.price = Convert.ToDecimal("19.99");
                product.quantity = 2;

                products.Add(product);

                
                
                break;
            default:  // Anything Else,there is nothing
                break;
        }

        return products;
      //return Enumerable.Range(1, 5).Select(x => new Product {name = x.ToString("Product 0")});
    }
  }
}
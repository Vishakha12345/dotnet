using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class Product
    {     
            #region Product Fields
            private int productId;
            private string title;
            private string brand;
            private string description;
            private string imageURL;
            private float unitPrice;
            private Category category;
            private int balance;
            #endregion

            #region Product Constructor Methods
            public Product()
            {
            }
            public Product(int productId, string title, string brand)
            {
                this.productId = productId;
                this.title = title;
                this.brand = brand;
            }
            public Product(int productId, string title, string brand, Category category)
            {
                this.productId = productId;
                this.title = title;
                this.brand = brand;
                this.category = category;
            }
            public Product(int productId, string title, string brand, Category category, float unitPrice, int balance)
            {
                this.productId = productId;
                this.title = title;
                this.brand = brand;
                this.category = category;
                this.unitPrice = unitPrice;
                this.balance = balance;
            }
            public Product(int productId, string title, string brand, Category category, float unitPrice, int balance, string description, string imageURL)
            {
                this.productId = productId;
                this.title = title;
                this.brand = brand;
                this.category = category;
                this.unitPrice = unitPrice;
                this.balance = balance;
                this.description = description;
                this.imageURL = imageURL;
            }
            #endregion
            public int ProductId
            {
                get { return productId; }
                set { productId = value; }
            }
            [Required]
            public string Title
                {
                    get { return title; }
                    set { title = value; }
                }
            [Required]

           [StringLength(5,ErrorMessage ="Brand should be max 5 characters")]
            public string Brand
                {
                    get { return brand; }
                    set { brand = value; }
                }
            [Required]
            public string Description
                {
                    get { return description; }
                    set { description = value; }
                }
            public string ImageURL
                {
                    get
                    {
                        return imageURL;
                    }

                    set
                    {
                        imageURL = value;
                    }
                }

            [Required]
            [Range(5,300, ErrorMessage ="Unit price should be in range 5, 300")]
            public float UnitPrice
                {
                    get
                    {
                        return unitPrice;
                    }

                    set
                    {
                        unitPrice = value;
                    }
                }
            public Category CategoryInfo
            {
                get
                {
                    return category;
                }

                set
                {
                    category = value;
                }
            }
            public int Balance
            {
                get
                {
                    return balance;
                }

                set
                {
                    balance = value;
                }
            }
            public override string ToString()
            {
                return string.Format(@"ProductId: {0}, Title: {1}, Brand: {2}, UnitPrice: {3:c}, Balance: {4}
                \n Description: {5} \n Category: {6} \n ImageUrl: {7}",
                    productId, title, brand, unitPrice, balance, description, category.ToString(), imageURL);
            }
        }
    }
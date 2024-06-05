using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using PGShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Tests.Integration
{
    public class CategoryControllerTests : IClassFixture<PGShopApiFactory<Program>>
    {
        private readonly HttpClient client;

        public CategoryControllerTests(PGShopApiFactory<Program> appFactory)
        {

            appFactory.ClientOptions.BaseAddress = new Uri("https://localhost:7238/api/");
            client = appFactory.CreateClient();
        }

        [Fact]
        public async Task Get_ReturnsNotFound_When_CategoryDoesntExist()
        {
            //Arrange
            Random rand = new Random();
            int Id = rand.Next(30, 50);

            //Act

            var response = await client.GetAsync($"categories/{Id}");

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            var problem = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();//deserialization
            problem!.Title.Should().Be("Not Found");


        }

        [Fact]
        public async Task Create_NewCategory_WhenDataIsValid()
        {
            //Arrange
            var model = new CategoryModel()
            {
                Categoryname = "Test",
                Description = "Test description",
            };


            //Act
            //"https://localhost:7238/api/" + categories -> https://localhost:7238/api/categories
            var response = await client.PostAsJsonAsync("categories", model);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);

            var categoryResponse = await response.Content.ReadFromJsonAsync<CategoryModel>();

            var expectedHeaderValue = $"{client.BaseAddress}categories/{categoryResponse.Categoryid}";
            //Location header
            var actualHeaderValue = response.Headers.Location!.ToString();

            expectedHeaderValue.Should().BeEquivalentTo(actualHeaderValue);

        }

    }
}

using AutoMapper;
using PGShop.Controllers;
using PGShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using PGShop.Mappers;
using NSubstitute.ReturnsExtensions;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using PGShop.Models;
using PGShop.Domain.Entities;

namespace PGShop.Tests.Unit
{
    public class CategoriesControllerTests
    {
        private readonly CategoriesController sut;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;


        public CategoriesControllerTests()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<CategoryProfile>());
            this.mapper = config.CreateMapper();

            this.categoryService = Substitute.For<ICategoryService>();
            sut = new CategoriesController(categoryService, mapper);
        }

        [Fact]
        public void GetById_ReturnNotFound()
        {
            var Id = 2;
            //Arrange
            categoryService.GetCategory(Id).ReturnsNull();

            //Act 
            var result = sut.GetCategory(Id);
            var statusCode = result.Result as NotFoundResult;

            //Assert
            statusCode.StatusCode.Should().Be(404);
        }


        [Fact]
        public void Create_ReturnsCreated_WhenDataIsValid()
        {
            //Arrange
            var model = new CategoryModel()
            {
               // Categoryid = 1,
                Description = "Test description",
                Categoryname = "Test"
            };

            var categoryToSave = mapper.Map<Category>(model);
            categoryToSave.Categoryid = 1;//act like the db set the value

            categoryService.AddNewCategory(categoryToSave)
                .Returns(categoryToSave);

            //Act
            var result = sut.Create(model);

            //Assert
            var statusCode = result.Result as CreatedAtActionResult;
            statusCode.StatusCode.Should().Be(201);
        }

    }
}

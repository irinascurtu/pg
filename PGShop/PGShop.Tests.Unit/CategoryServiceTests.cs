﻿using PGShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using PGShop.Data;
using PGShop.Domain.Entities;
using FluentAssertions;

namespace PGShop.Tests.Unit
{
    public class CategoryServiceTests
    {
        private readonly ICategoryService subjectUnderTest;
        private readonly ICategoryRepository categoryRepository;

        public CategoryServiceTests()
        {
            this.categoryRepository = Substitute.For<ICategoryRepository>();
            this.subjectUnderTest = new CategoryService(categoryRepository);
        }

        [Fact]
        public void GetCategory_Should_ReturnCategory_WhenCategoryExists()
        {
            //Arrange
            var existingCategory = new Category()
            {
                Categoryid = 1,
                Categoryname = "test",
                Description = "test description"
            };

            categoryRepository.GetById(existingCategory.Categoryid)
                .Returns(existingCategory);
            //Act
            //expected == actual
            var actualResult = subjectUnderTest.GetCategory(existingCategory.Categoryid);

            //Assert
            actualResult.Should().NotBeNull();
            actualResult.Should().BeEquivalentTo(existingCategory);

        }

        [Fact]
        public void GetCategory_Should_ReturnNotFound_WhenCategoryDoesntExist()
        {

        }

        [Fact]
        public void CheckIfCategoryExists_ById()
        {
            //Arrange
            // return categoryRepository.Exists(id);
            categoryRepository.Exists(2).Returns(true);
            //Act

            var expectedResult = subjectUnderTest.CheckIfExists(2);

            //Assert
            expectedResult.Should().BeTrue();


        }

        [Fact]
        public void CheckIfCategoryExists_ByCategoryName()
        {
            //Arrange
            var categoryName = "test";
            categoryRepository.Exists(categoryName).Returns(true);
            //Act

            var expectedResult = subjectUnderTest.CheckIfExists(categoryName);
            //Assert
            expectedResult.Should().BeTrue();

        }
    }
}

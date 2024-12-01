﻿global using AutoMapper;
global using FluentValidation;
global using FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Repositories;
global using Repositories.Categories;
global using Repositories.Products;
global using Services.Categories;
global using Services.Categories.Create;
global using Services.Categories.Dto;
global using Services.Categories.Update;
global using Services.ExceptionHandlers;
global using Services.Products;
global using Services.Products.Create;
global using Services.Products.Update;
global using Services.Products.UpdateStock;
global using System.Net;
global using System.Net.Mime;
global using System.Reflection;
global using System.Text.Json.Serialization;
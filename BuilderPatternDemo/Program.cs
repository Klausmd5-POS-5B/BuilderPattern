// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using BuilderPatternDemo;

Console.WriteLine("Hello, World!");

var product = new Product.Builder("ReqA", "ReqB").SetOptionalC(25).SetOptionalD("OptionalD").Build();

Console.WriteLine(JsonSerializer.Serialize(product));

var product2 = new Product.Builder("ReqA", "ReqB").SetOptionalD("OptionalD").Build();

Console.WriteLine(JsonSerializer.Serialize(product2));

var product3 = new Product.Builder("ReqA", "anel").SetOptionalD("OptionalD").Build();

Console.WriteLine(JsonSerializer.Serialize(product3));
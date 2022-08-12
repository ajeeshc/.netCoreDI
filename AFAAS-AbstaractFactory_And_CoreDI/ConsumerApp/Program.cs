// See https://aka.ms/new-console-template for more information
using FacadeLayer;
using Implimentation;
using Implimentation.Factory;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;


Console.WriteLine("AFAAS CONSUMER");
var container = ContainerBuilder.ConfigService();
var step = container.GetRequiredService<IStep>();
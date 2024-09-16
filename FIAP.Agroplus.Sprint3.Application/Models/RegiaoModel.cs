﻿namespace FIAP.Agroplus.Sprint3.Application.Models;

public class RegiaoModel
{
    public string Nome { get; set; } = string.Empty;
    public string RegiaoBR { get; set; } = string.Empty;
    public string PlantioMaisFrequente { get; set; } = string.Empty;
    public decimal TemperaturaMedia { get; set; }
    public decimal PrecipitacaoMedia { get; set; }
}

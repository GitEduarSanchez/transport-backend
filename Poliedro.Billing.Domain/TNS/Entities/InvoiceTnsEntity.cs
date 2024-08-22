namespace Poliedro.Billing.Domain.TNS.Entities;

public class InvoiceTnsEntity
{
    public string Prefix { get; set; } = string.Empty;
    public int Number { get; set; }
    public DateTime Fecha { get; set; }
    public string Customer { get; set; } = string.Empty;
    public string Seller { get; set; } = string.Empty;
    public string Dispatcher { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public string Bank { get; set; } = string.Empty;
    public DateTime DateExpiration { get; set; } = DateTime.MinValue;
    public int plazoDias { get; set; } = 0;
    public string Observation { get; set; } = string.Empty;
    public Item[] Items { get; set; } = [];
    public PaymentMethod[] PaymentMethods { get; set; } = [];
    public Discount[] Discounts { get; set; } = [];
}

public class Discount
{
    public string Concept { get; set; } = string.Empty;
    public decimal Value { get; set; } = 0;
    public decimal RetentionBase { get; set; } = 0;
    public decimal RetentionPercentent { get; set; } = 0;
    public decimal TaxPercentent { get; set; } = 0;
    public string CostCenter { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
}

public class Item
{
    public string Material { get; set; } = string.Empty;
    public string Store { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public decimal Quantity { get; set; } = 0;
    public string Unit { get; set; } = string.Empty;
    public decimal Discount { get; set; } = 0;
    public string? CostCenter { get; set; } = string.Empty;
    public int TaxPercentent { get; set; } = 0;
    public int Value { get; set; } = 0;
    public int TaxConsume { get; set; } = 0;
    public string Observation { get; set; } = string.Empty;
}

public class PaymentMethod
{
    public string Payment { get; set; } = string.Empty;
    public int DaysTerm { get; set; } = 0;
    public DateTime DateExpiration { get; set; } = DateTime.MinValue;
    public decimal Value { get; set; } = 0;
}



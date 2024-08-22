namespace Poliedro.Billing.Domain.Plemsi.Entities;

    public class InvoicePlemsiEntity
    {
        public int Number { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public bool SendEmail { get; set; } = true;
        public bool IsFinalCustomer { get; set; } = true;
        public Attachment Attachment1 { get; set; } = default!;
        public Attachment Attachment2 { get; set; } = default!;
        public OrderReference OrderReference { get; set; } = default!;
        public GeneralAllowances[] GeneralAllowances { get; set; } = [];
        public string Resolution { get; set; } = string.Empty;
        public string ResolutionText { get; set; } = string.Empty;
        public string Prefix { get; set; } = string.Empty;
        public string HeadNote { get; set; } = string.Empty;
        public string FootNote { get; set; } = string.Empty;
        public Payment Payment { get; set; } = default!;
        public decimal InvoiceBaseTotal { get; set; } = default!;
        public decimal InvoiceTaxExclusiveTotal { get; set; } = default!;
        public decimal InvoiceTaxInclusiveTotal { get; set; } = default!;
        public decimal TotalToPay { get; set; } = default!;
        public TaxTotal[] AllTaxTotals { get; set; } = [];
        public Item[] Items { get; set; } = [];
        public string Notes { get; set; } = string.Empty;
        public decimal AllowanceTotal { get; set; } = default!;
        public AllHoldingsTaxTotals[] AllHoldingsTaxTotals { get; set; } = [];
        public CustomSubtotals[] CustomSubtotals { get; set; } = [];
        public decimal FinalTotalToPay { get; set; } = default!;
    }

    public class AllHoldingsTaxTotals
    {
        public int TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public int Percent { get; set; }
        public decimal TaxableAmount { get; set; }
    }

    public class AllowanceCharges
    {
        public bool ChargeIndicator { get; set; }
        public string AllowanceChargeReason { get; set; } = string.Empty;
        public int MultiplierFactorNumeric { get; set; }
        public decimal Amount { get; set; }
        public decimal BaseAmount { get; set; }
    }

    public class Attachment
    {
        public string FileName { get; set; } = string.Empty;
        public string B64data { get; set; } = string.Empty;

    }

    public class CustomSubtotals
    {
        public string Concept { get; set; } = string.Empty;
        public decimal Amount { get; set; } = decimal.Zero;
    }

    public class GeneralAllowances
    {
        public string AllowanceChargeReason { get; set; } = string.Empty;
        public int AllowancePercent { get; set; }
        public decimal Amount { get; set; }
        public decimal BaseAmount { get; set; }
    }

    public class Item
    {
        public int UnitMeasureId { get; set; }
        public decimal InvoicedQuantity { get; set; }
        public decimal LineExtensionAmount { get; set; }
        public bool FreeOfChargeIndicator { get; set; }
        public TaxTotal[] TaxTotals { get; set; } = [];
        public List<AllowanceCharges> AllowanceCharges { get; set; } = [];
        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int TypeItemIdentificationId { get; set; }
        public decimal PriceAmount { get; set; }
        public decimal BaseQuantity { get; set; }
    }

    public class OrderReference
    {
        public string IdOrder { get; set; } = string.Empty;
    }

    public class Payment
    {
        public int PaymentFormId { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentDueDate { get; set; } = string.Empty;
        public string DurationMeasure { get; set; } = string.Empty;
    }

    public class TaxTotal
    {
        public int TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Percent { get; set; }
        public decimal TaxableAmount { get; set; }
    }

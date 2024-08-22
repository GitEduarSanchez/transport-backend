namespace Poliedro.Billing.Domain.ClientBillintElectronic.Entities
{
    public class ClientBillingElectronicViewEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Active { get; set; } = 0;
        public int ProviderId { get; set; } = 0;
        public int ResolutionId { get; set; } = 0;
        public string ResolutionNumber { get; set; } = string.Empty;
        public string ResolutionPrefix { get; set; } = string.Empty;
        public int ResolutionInitialRange { get; set; } = 0;
        public int ResolutionFinalRange { get; set; } = 0;
        public DateOnly ResolutionDate { get; set; } = default;
        public string ResolutionDescription { get; set; } = string.Empty;
        public string ResolutionFile { get; set; } = string.Empty;
        public int ResolutionActive { get; set; } = 0;
        public DateTime ResolutionCreationDate { get; set; } = default;
        public int ResolutionVigencyMonth { get; set; } = 0;
        public DateOnly ResolutionExpitarionDate { get; set; } = default;
        public string ResolutionType { get; set; } = string.Empty;
        public int ServerId { get; set; } = 0;
        public string ServerIp { get; set; } = string.Empty;
        public string ServerDatabaseName { get; set; } = string.Empty;
        public string ServeUserName { get; set; } = string.Empty;
        public string ServePassword { get; set; } = string.Empty;
    }


}

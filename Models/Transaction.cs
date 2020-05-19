public class Transaction
{
  public long Id { get; set; }
  public long ExternalId { get; set; }
  public string Description { get; set; }
  public decimal Ammount { get; set; }
  public bool IsCredit { get; set; }

}
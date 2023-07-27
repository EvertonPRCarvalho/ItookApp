using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace ItookApp.Domain.Products;

public class Category : Entity
{
    public bool Active { get; set; }

    public Category() { }
   // public Category(string name, string createdBy, string editedBy)
   // {
    //    var contract = new Contract<Category>()
    //        .IsNotNullOrEmpty(name, "Name");
     //   AddNotifications(contract);

     //   Name = name;
     //   Active = true;
     //   CreatedBy = createdBy;
      //  CreatedOn = DateTime.UtcNow;
      //  EditedBy = editedBy;
      //  EditedOn = DateTime.UtcNow;
    //}
}

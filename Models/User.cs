using System;

namespace DotnetHandsontableExample.Models
{
    public class User
    {
      private int id;
      private string firstName;
      private string lastName;
      private string email;
      private bool active;

      public User(int id, string firstName, string lastName, string email, bool active)
      {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.active = active;
      }

      public int Id
      {
        get { return id;  }
        set { id = value; }
      }

      public string FirstName
      {
        get { return firstName; }
        set { firstName = value; }
      }

      public string LastName
      {
        get { return lastName; }
        set { lastName = value; }
      }

      public string Email
      {
        get { return email; }
        set { email = value; }
      }

      public bool Active
      {
        get { return active; }
        set { active = value; }
      }
    }
}

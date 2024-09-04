using System.ComponentModel.DataAnnotations;

namespace DotNetAPIDocker.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}
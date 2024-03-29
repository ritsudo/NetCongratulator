using System;
using System.ComponentModel.DataAnnotations;

namespace NetCongratulator.Domain;

public class UserCard
{
    public int Id { get; set;}
	
	public DateTime? CreatedAt {get; set;}
	
	public DateTime? UpdatedAt {get; set;}
	
    [Required]
    [MaxLength(100)]
    public string? FirstName {get; set;}
	
    [Required]
    [MaxLength(100)]
    public string? LastName {get; set;}
	
    [Required]
    public DateTime? BirthdayDate {get; set;}
	
    public string? ImageName {get; set;}
}
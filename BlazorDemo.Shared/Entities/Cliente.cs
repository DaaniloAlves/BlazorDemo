using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared.Entities
{
	public class Cliente
	{
		public int Id { get; set; }
		[Required]
		[StringLength(6)]
		public string Name { get; set; } = string.Empty;
		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;
		[Required]
		[Range(18, 80)]
		public int Idade { get; set; }


	}
}

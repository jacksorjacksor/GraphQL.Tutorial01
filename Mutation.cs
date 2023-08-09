using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIT.GraphQL.Test02
{
	public class Mutation
	{
		public async Task<Person> AddPerson(Person person, [Service] PersonRepository personRepository)
		{
			personRepository.AddPerson(person);
			return person;
		}
	}
}

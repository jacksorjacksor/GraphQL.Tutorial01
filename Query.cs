using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIT.GraphQL.Test02
{
	public class Query
	{
		public Person GetPerson(int id, [Service] PersonRepository personRepository) => personRepository.GetPerson(id);

		public List<Person> GetPersons([Service] PersonRepository personRepository) { return personRepository.GetPersons(); }
	}
}

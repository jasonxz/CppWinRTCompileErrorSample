using InterfaceDefinitionComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationComponent {

	public sealed class InterfaceImplementation : InterfaceDefinition {

		public int GetInt() {
			return 1;
		}
	}
}
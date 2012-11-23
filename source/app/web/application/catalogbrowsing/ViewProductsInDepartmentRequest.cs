using System.Collections.Generic;

namespace app.web.application.catalogbrowsing
{
	public class ViewProductsInDepartmentRequest
	{
		public IEnumerable<Department> department { get; set; }
	}
}
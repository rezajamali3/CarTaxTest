using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCar.Combinedstation.Applaication.Validator;

namespace TaxCar.Combinedstation.Applaication.Feature
{

    public class Commands
    {

        public static class V1
        {

            public class Create : ICombinedstationValidatorConfig
            {
                public string Name { get; set; }

                public int AreaId { get; set; }

                public string Code { get; set; }

                public bool IsActive { get; set; }
            }

            public class Update : ICombinedstationValidatorConfig
            {

                public Guid   Id { get; set; }

                public string Name { get; set; }

                public int    AreaId { get; set; }

                public string Code { get; set; }

                public bool   IsActive { get; set; }

            }

            public class Delete
            {
                public Guid CombinedStationsId { get; set; }
            }

        }

    }

}

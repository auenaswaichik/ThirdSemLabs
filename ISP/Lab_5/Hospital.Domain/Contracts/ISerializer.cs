using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital;

namespace Hospital.Domain.Contracts;
public interface ISerializer
{
    IEnumerable<Hospital> DeSerializeByLINQ(string fileName);
    IEnumerable<Hospital> DeSerializeXML(string fileName);
    IEnumerable<Hospital> DeSerializeJSON(string fileName);
    void SerializeByLINQ(IEnumerable<Hospital> hospitals, string fileName);
    void SerializeXML(IEnumerable<Hospital> hospitals, string fileName);
    void SerializeJSON(IEnumerable<Hospital> hospitals, string fileName);

}

using System.Collections.Generic;
using Cubes.Core.Email;

namespace Cubes.Core.Commands.Basic
{
    public class SqlResultsAsEmailResult : BaseCommandResult
    {
        public EmailContent EmailContent { get; set; }
        public SmtpSettings SmtpSettings { get; set; }
        public Dictionary<string, IEnumerable<dynamic>> SqlResults { get; set; }
    }
}
using System.Collections.Generic;
using System.IO;

namespace Mustache
{

    public class UrlEncodeTagDefinition : ContentTagDefinition {
        public UrlEncodeTagDefinition()
            : base("urlencode") {
        }

        public override IEnumerable<NestedContext> GetChildContext(TextWriter writer,Scope keyScope,Dictionary<string, object> arguments,Scope contextScope) {
            NestedContext context = new NestedContext() {
                KeyScope = keyScope,
                Writer = new StringWriter(),
                WriterNeedsConsidated = true,
            };
            yield return context;
        }

        public override IEnumerable<TagParameter> GetChildContextParameters() {
            return new TagParameter[] { new TagParameter("collection") };
        }

        public override string ConsolidateWriter(TextWriter writer, Dictionary<string, object> arguments) {
            return System.Net.WebUtility.UrlEncode(writer.ToString());
        }
    }
}
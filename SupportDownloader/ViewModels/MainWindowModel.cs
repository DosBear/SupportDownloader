using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SupportDownloader
{
    public class MainWindowModel
    {
        public event EventHandler<EventArgs<string>> PercentageChanged;
        public async Task HttpGetForLargeFile(string path, string filename, CancellationToken token)
        {
            if (File.Exists(filename)) File.Delete(filename);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(path,
                   HttpCompletionOption.ResponseHeadersRead))
                {
                    var total = response.Content.Headers.ContentLength.HasValue ?
                       response.Content.Headers.ContentLength.Value : -1L;
                    var canReportProgress = total != -1;
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        using (BinaryWriter binWriter = new BinaryWriter(File.Open(filename, FileMode.Append)))
                        {
                        var totalRead = 0L;
                        var buffer = new byte[4096];
                        var moreToRead = true;
                        do
                        {
                            token.ThrowIfCancellationRequested();
                            var read = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                            if (read == 0)
                            {
                                moreToRead = false;
                            }
                            else
                            {
                                var data = new byte[read];
                                buffer.ToList().CopyTo(0, data, 0, read);
                                binWriter.Write(data);
                                totalRead += read;
                                if (canReportProgress)
                                {
                                    var downloadPercentage = ((totalRead * 1d) / (total * 1d)) * 100;
                                    var value = Convert.ToInt32(downloadPercentage);
                                    PercentageChanged.Raise(this, (value.ToString()));
                                }
                            } 
                        }
                        while (moreToRead);
                        }

                    }
                }
            }
        }
    }
}

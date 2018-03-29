using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;

namespace ConsoleApp1.Services
{
    public class CustomerCsvProcessorService
    {
        private StreamReader _stream;
        private CsvReader _csvReader;
        private int? _totalRecords;

        #region Constructors

        public CustomerCsvProcessorService(StreamReader stream)
        {
            _stream = stream;
            _csvReader = new CsvReader(stream);
            _csvReader.Configuration.RegisterClassMap<CustomerImportCsvMap>();
        }

        #endregion
        
        #region Public API
        
        public Task StartAsync()
        {
            var task = new Task(StartProcessing);

            task.Start();

            return task;
        }

        #endregion

        #region Private Methods

        private int TotalCustomers()
        {
            // If _totalRecords is not null then we already ran the calculation once. There's
            // no reason the underlying stream should change after this service is constructed
            // so we will return the cached record total.
            //
            // If the stream changed, well it's expected that a new instance of this class
            // will be created for the updated stream.
            if (_totalRecords != null)
            {
                return _totalRecords.Value;
            }

            _resetStreamToBeginning();

            var i = 0;

            while (_csvReader.Read())
            {
                i++;
            }

            // The header row was counted, so subtract 1 from the total
            _totalRecords = i - 1;

            _resetStreamToBeginning();

            return _totalRecords ?? 0;
        }

        /// <summary>
        /// Resets the underlying <see cref="_stream"/> cursor position to the beginning
        /// of the Stream.
        /// </summary>
        private void _resetStreamToBeginning()
        {
            // Reset the cursor position in the memory stream
            _stream.BaseStream.Seek(0, SeekOrigin.Begin);

            // Let CsvHelper realize it has to read the header record again
            _csvReader.Context.HeaderRecord = null;
        }

        private void StartProcessing()
        {
            //var rows = _csvReader.GetRecords<CustomerImportCsvRowDto>();
            
            try
            {
                var iterationNumber = 0;

                _csvReader.Read();
                _csvReader.ReadHeader();
                while (_csvReader.Read())
                {
                    iterationNumber++;

                    var row = _csvReader.GetRecord<CustomerImportCsvRowDto>();
                }
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

        #endregion
    }
}
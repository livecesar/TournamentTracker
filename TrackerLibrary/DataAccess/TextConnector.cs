using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        // TODO - Wire u´p the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the file and convert to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max Id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId= prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new Id
            prizes.Add(model);

            //Convert the prizes to List<string> and saves rhe List<string> into the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}

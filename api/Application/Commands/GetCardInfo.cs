using PCSC;
using System;
using System.Collections.Generic;
using System.Linq;
using PCSC.Iso7816;
using Serilog;
using api.Application.Models;

namespace api.Application.Commands
{
    public class GetCardInfo
    {
        private static IContextFactory _contextFactory = ContextFactory.Instance;
        private static bool isEmpty = true;

        private string _err = "";
        private string _readerName = "";
        private string _protocol = "";
        private string _state = "";
        private string _cardAttr = "";
        private string _msg = "";



        public GetCardInfo()
        {
            _err = "";
            _readerName = "";
            _protocol = "";
            _state = "";
            _cardAttr = "";
            _msg = "";

            using (var context = _contextFactory.Establish(SCardScope.System))
            {
                var readerNames = context.GetReaders();

                if (IsEmpty(readerNames))
                {
                    isEmpty = false;
                    return;
                }

                //GetReaderStatus(context, readerNames);



            }
        }

        public bool IsAnyReaders()
        {
            return isEmpty;
        }

        private static bool IsEmpty(ICollection<string> readerNames) => readerNames == null || readerNames.Count < 1;

        public IDCard RetrieveCardInfo()
        {
            return new IDCard
            {
                Err = _err,
                ReaderName = _readerName,
                Protocol = _protocol,
                State = _state,
                CardAttr = _cardAttr,
                Msg = _msg,


            };
        }


    }
}

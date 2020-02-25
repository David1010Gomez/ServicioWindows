using ServiceTest.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceTest.Bussines
{
    public class GestorDeHilos : LogHandler
    {
        //public void Create(ServiceTest service, ref List<FalabellaThread> threads)
        //{
        //    try
        //    {
        //        Thread worketThread = new Thread(txPayu.Start);
        //        FalabellaThread hilo = new FalabellaThread(service) { Thread = worketThread };
        //        threads.Add(hilo);
        //    }
        //    catch (Exception ex)
        //    {
        //        Write("logTraza", "GestorDeHilos.Create: " + ex.Message + "\n" + ex.StackTrace);
        //        //LogBD("BFCO.ReenvioTxPayu", "GestorDeHilos.Create", ex);
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="threads"></param>
        //public void Destroy(ref List<FalabellaThread> threads)
        //{
        //    int cantidadHilos = threads.Count;
        //    foreach (FalabellaThread hilo in threads)
        //    {
        //        hilo.Thread.Abort();
        //    }
        //    threads.Clear();
        //}
    }
}

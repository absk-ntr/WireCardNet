﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WireCardNet.Processing
{
    public class ProcessingResponse
    {
        private List<JobResponse> jobs = new List<JobResponse>();

        internal ProcessingResponse(XmlNode n)
        {
            foreach (XmlNode job in n.SelectNodes("W_RESPONSE/W_JOB"))
            {
                jobs.Add(new JobResponse(job));
            }
        }

        /// <summary>
        /// Finds the status of a transaction in this response
        /// </summary>
        /// <param name="jobId">job id to look for</param>
        /// <param name="functionId">function id to look for</param>
        /// <param name="transactionId">transaction id to look for</param>
        /// <returns>A ProcessingStatus of the transaction or null if the transaction was not found</returns>
        public ProcessingStatus FindStatus(string jobId, string functionId, string transactionId)
        {
            var job = jobs.FirstOrDefault(j => j.JobId == jobId);

            if (job == null)
            {
                return null;
            }

            var function = job.FindFunction(functionId);

            if (function == null)
            {
                return null;
            }

            var transaction = function.FindTransaction(transactionId);

            if (transaction == null)
            {
                return null;
            }

            return transaction.ProcessingStatus;
        }
    }
}

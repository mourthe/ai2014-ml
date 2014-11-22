﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class FileReader
    {
        public Reviews Reviews;
        private int _idx;

        public FileReader()
        {
            _idx = 0;
            Reviews = new Reviews();
        }

        /// <summary>
        /// Initialize the reviews list.
        /// </summary>
        /// <param name="path">Path to a folder containg all the reviews</param>
        public void InitializeReviews(string path)
        {
            var files = Directory.GetFiles(path);

            foreach (var reader in files.Select(file => new StreamReader(file)))
            {
                while (!reader.EndOfStream)
                {
                    Reviews.Content[_idx++] = reader.ReadLine();
                }
            }
        }
    }
}
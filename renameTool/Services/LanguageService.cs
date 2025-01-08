using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameTool.Data
{
    public class LanguageService
    {
        private static readonly Language[] Languages = new Language[]
        {
            new Language() {
                Lang = "Spanish",
                Lang2Code = "es",
                Lang3Code = "spa"
            },
            new Language() {
                Lang = "English",
                Lang2Code = "en",
                Lang3Code = "eng"
            },
            new Language() {
                Lang = "Basque",
                Lang3Code = "baq"
            },
            new Language() {
                Lang = "Catalan",
                Lang3Code = "cat"
            },
            new Language() {
                Lang = "Chinese",
                Lang3Code = "chi"
            },
            new Language() {
                Lang = "Arabic",
                Lang3Code = "ara"
            },
            new Language() {
                Lang = "Danish",
                Lang3Code = "dan"
            },
            new Language() {
                Lang = "German",
                Lang3Code = "ger"
            },
            new Language() {
                Lang = "Dutch",
                Lang3Code = "dut"
            },
            new Language() {
                Lang = "Finnish",
                Lang3Code = "fin"
            },
            new Language() {
                Lang = "French",
                Lang3Code = "fre"
            },
            new Language() {
                Lang = "Hebrew",
                Lang3Code = "heb"
            },
            new Language() {
                Lang = "Indonesian",
                Lang3Code = "ind"
            },
            new Language() {
                Lang = "Italian",
                Lang3Code = "ita"
            },
            new Language() {
                Lang = "Korean",
                Lang3Code = "kor"
            },
            new Language() {
                Lang = "Bokmal"
            },
            new Language() {
                Lang = "Polish",
                Lang3Code = "pol"
            },
            new Language() {
                Lang = "Portuguese",
                Lang3Code = "por"
            },
            new Language() {
                Lang = "Russian",
                Lang3Code = "rus"
            },
            new Language() {
                Lang = "Swedish"
            },
            new Language() {
                Lang = "Thai",
                Lang3Code = "tha"
            },
            new Language() {
                Lang = "Turkish",
                Lang3Code = "tur"
            }
        };

        public Task<Language[]> GetAllLanguages()
        {
            return Task.FromResult(Languages);
        }
    }
}

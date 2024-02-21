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
                Lang = "Chinese"
            },
            new Language() {
                Lang = "Arabic"
            },
            new Language() {
                Lang = "Danish"
            },
            new Language() {
                Lang = "German",
                Lang3Code = "dut"
            },
            new Language() {
                Lang = "Finnish"
            },
            new Language() {
                Lang = "French"
            },
            new Language() {
                Lang = "Hebrew"
            },
            new Language() {
                Lang = "Indonesian"
            },
            new Language() {
                Lang = "Italian"
            },
            new Language() {
                Lang = "Korean"
            },
            new Language() {
                Lang = "Bokmal"
            },
            new Language() {
                Lang = "Dutch"
            },
            new Language() {
                Lang = "Polish"
            },
            new Language() {
                Lang = "Portuguese"
            },
            new Language() {
                Lang = "Russian"
            },
            new Language() {
                Lang = "Swedish"
            },
            new Language() {
                Lang = "Thai"
            },
            new Language() {
                Lang = "Turkish"
            }
        };

        public Task<Language[]> GetAllLanguages()
        {
            return Task.FromResult(Languages);
        }
    }
}

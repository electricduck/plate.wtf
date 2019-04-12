using System.Collections.Generic;
using plate.wtf.Core.Interfaces;
using plate.wtf.Core.Plates.Interfaces;
using Model = plate.wtf.Models;

namespace plate.wtf.Core
{
    public class Plate : IPlate
    {
        public IAlPlate _alPlate { get; }
        public IAtPlate _atPlate { get; }
        public IDePlate _dePlate { get; }
        public IEsPlate _esPlate { get; }
        public IFiPlate _fiPlate { get; }
        public IFrPlate _frPlate { get; }
        public IGbPlate _gbPlate { get; }
        public IGbNirPlate _gbNirPlate { get; set; }
        public IGgPlate _ggPlate { get; }
        public IHuPlate _huPlate { get; }
        public IIePlate _iePlate { get; }
        public IItPlate _itPlate { get; }
        public IJpPlate _jpPlate { get; }
        public ILtPlate _ltPlate { get; }
        public ILvPlate _lvPlate { get; }
        public INlPlate _nlPlate { get; }
        public INoPlate _noPlate { get; }
        public IPlPlate _plPlate { get; }
        public IRuPlate _ruPlate { get; }
        public ISePlate _sePlate { get; }

        public Plate
        (
            IAlPlate alPlate,
            IAtPlate atPlate,
            IDePlate dePlate,
            IEsPlate esPlate,
            IFiPlate fiPlate,
            IFrPlate frPlate,
            IGbPlate gbPlate,
            IGbNirPlate gbNirPlate,
            IGgPlate ggPlate,
            IHuPlate huPlate,
            IIePlate iePlate,
            IItPlate itPlate,
            IJpPlate jpPlate,
            ILtPlate ltPlate,
            ILvPlate lvPlate,
            INlPlate nlPlate,
            INoPlate noPlate,
            IPlPlate plPlate,
            IRuPlate ruPlate,
            ISePlate sePlate
        )
        {
            _alPlate = alPlate;
            _atPlate = atPlate;
            _dePlate = dePlate;
            _esPlate = esPlate;
            _fiPlate = fiPlate;
            _frPlate = frPlate;
            _gbPlate = gbPlate;
            _gbNirPlate = gbNirPlate;
            _ggPlate = ggPlate;
            _huPlate = huPlate;
            _iePlate = iePlate;
            _itPlate = itPlate;
            _jpPlate = jpPlate;
            _ltPlate = ltPlate;
            _lvPlate = lvPlate;
            _nlPlate = nlPlate;
            _noPlate = noPlate;
            _plPlate = plPlate;
            _ruPlate = ruPlate;
            _sePlate = sePlate;
        }

        public List<Model.Plate> ParsePlate(string plate, string country = "")
        {
            List<Model.Plate> platesReturn = new List<Model.Plate>();

            country = country.ToLower();
            plate = plate
                .ToUpper()
                .Replace(" ", "");

            if(country.Length == 2 || country.Length == 6)
            {
                switch(country)
                {
                    case "al":
                        var parsedAlPlate = _alPlate.Parse(plate);
                        platesReturn.Add(parsedAlPlate);
                        break;
                    case "at":
                        var parsedAtPlate = _atPlate.Parse(plate);
                        platesReturn.Add(parsedAtPlate);
                        break;
                    case "de":
                        var parsedDePlate = _dePlate.Parse(plate);
                        platesReturn.Add(parsedDePlate);
                        break;
                    //case "es":
                    //    var parsedEsPlate = _esPlate.Parse(plate);
                    //    platesReturn.Add(parsedEsPlate);
                    //    break;
                    case "fi":
                        var parsedFiPlate = _fiPlate.Parse(plate);
                        platesReturn.Add(parsedFiPlate);
                        break;
                    case "fr":
                        var parsedFrPlate = _frPlate.Parse(plate);
                        platesReturn.Add(parsedFrPlate);
                        break;
                    case "gb":
                    case "uk":
                        var parsedGbPlate = _gbPlate.Parse(plate);
                        platesReturn.Add(parsedGbPlate);
                        break;
                    case "gb-nir":
                        var parsedGbNirPlate = _gbNirPlate.Parse(plate);
                        platesReturn.Add(parsedGbNirPlate);
                        break;
                    case "gg":
                        var parsedGgPlate = _ggPlate.Parse(plate);
                        platesReturn.Add(parsedGgPlate);
                        break;
                    case "hu":
                        var parsedHuPlate = _huPlate.Parse(plate);
                        platesReturn.Add(parsedHuPlate);
                        break;
                    case "ie":
                        var parsedIePlate = _iePlate.Parse(plate);
                        platesReturn.Add(parsedIePlate);
                        break;
                    case "it":
                        var parsedItPlate = _itPlate.Parse(plate);
                        platesReturn.Add(parsedItPlate);
                        break;
                    case "jp":
                        var parsedJpPlate = _jpPlate.Parse(plate);
                        platesReturn.Add(parsedJpPlate);
                        break;
                    case "lt":
                        var parsedLtPlate = _ltPlate.Parse(plate);
                        platesReturn.Add(parsedLtPlate);
                        break;
                    case "lv":
                        var parsedLvPlate = _lvPlate.Parse(plate);
                        platesReturn.Add(parsedLvPlate);
                        break;
                    case "nl":
                        var parsedNlPlate = _nlPlate.Parse(plate);
                        platesReturn.Add(parsedNlPlate);
                        break;
                    //case "no":
                    //    var parsedNoPlate = _noPlate.Parse(plate);
                    //    platesReturn.Add(parsedNoPlate);
                    //    break;
                    //case "pl":
                    //    var parsedPlPlate = _plPlate.Parse(plate);
                    //    platesReturn.Add(parsedPlPlate);
                    //    break;
                    case "ru":
                        var parsedRuPlate = _ruPlate.Parse(plate);
                        platesReturn.Add(parsedRuPlate);
                        break;
                    case "se":
                        var parsedSePlate = _sePlate.Parse(plate);
                        platesReturn.Add(parsedSePlate);
                        break;
                }
            }
            else if(country == "any")
            {
                platesReturn = ParseAnyPlate(plate);
            }

            return platesReturn;
        }

        public List<Model.Plate> ParseAnyPlate(string plate)
        {
            List<Model.Plate> matchesReturn = new List<Model.Plate>();

            var parsedAlPlate = _alPlate.Parse(plate);
            var parsedAtPlate = _atPlate.Parse(plate);
            var parsedDePlate = _dePlate.Parse(plate);
            //var parsedEsPlate = _esPlate.Parse(plate);
            var parsedFiPlate = _fiPlate.Parse(plate);
            var parsedFrPlate = _frPlate.Parse(plate);
            var parsedGbPlate = _gbPlate.Parse(plate);
            var parsedGbNirPlate = _gbNirPlate.Parse(plate);
            var parsedGgPlate = _ggPlate.Parse(plate);
            var parsedHuPlate = _huPlate.Parse(plate);
            var parsedIePlate = _iePlate.Parse(plate);
            var parsedItPlate = _itPlate.Parse(plate);
            var parsedJpPlate = _jpPlate.Parse(plate);
            var parsedLtPlate = _ltPlate.Parse(plate);
            var parsedLvPlate = _lvPlate.Parse(plate);
            var parsedNlPlate = _nlPlate.Parse(plate);
            //var parsedNoPlate = _noPlate.Parse(plate);
            //var parsedPlPlate = _plPlate.Parse(plate);
            var parsedRuPlate = _ruPlate.Parse(plate);
            var parsedSePlate = _sePlate.Parse(plate);

            if(parsedAlPlate.Valid) { matchesReturn.Add(parsedAlPlate); }
            if(parsedAtPlate.Valid) { matchesReturn.Add(parsedAtPlate); }
            if(parsedDePlate.Valid) { matchesReturn.Add(parsedDePlate); }
            //if(parsedEsPlate.Valid) { matchesReturn.Add(parsedEsPlate); }
            if(parsedFiPlate.Valid) { matchesReturn.Add(parsedFiPlate); }
            if(parsedFrPlate.Valid) { matchesReturn.Add(parsedFrPlate); }
            if(parsedGbPlate.Valid) { matchesReturn.Add(parsedGbPlate); }
            if(parsedGbNirPlate.Valid) { matchesReturn.Add(parsedGbNirPlate); }
            if(parsedGgPlate.Valid) { matchesReturn.Add(parsedGgPlate); }
            if(parsedHuPlate.Valid) { matchesReturn.Add(parsedHuPlate); }
            if(parsedItPlate.Valid) { matchesReturn.Add(parsedItPlate); }
            if(parsedIePlate.Valid) { matchesReturn.Add(parsedIePlate); }
            if(parsedJpPlate.Valid) { matchesReturn.Add(parsedJpPlate); }
            if(parsedLtPlate.Valid) { matchesReturn.Add(parsedLtPlate); }
            if(parsedLvPlate.Valid) { matchesReturn.Add(parsedLvPlate); }
            if(parsedNlPlate.Valid) { matchesReturn.Add(parsedNlPlate); }
            //if(parsedNoPlate.Valid) { matchesReturn.Add(parsedNoPlate); }
            //if(parsedPlPlate.Valid) { matchesReturn.Add(parsedPlPlate); }
            if(parsedRuPlate.Valid) { matchesReturn.Add(parsedRuPlate); }
            if(parsedSePlate.Valid) { matchesReturn.Add(parsedSePlate); }

            return matchesReturn;
        }
    }
}
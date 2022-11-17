using System.ComponentModel.DataAnnotations;

namespace LimeFlightTakeHomeChallenge.DAL.Models
{
    public class Flight
    {
        /// <summary>
        /// A unique ID
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// A unique ID from the airline's system
        /// </summary>
        public string ExternalId { get; set; }
        /// <summary>
        /// The carrier ID
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// The number of the flight
        /// </summary>
        public int Flightnumber { get; set; }
        /// <summary>
        /// Codeshare ID, if flight is a codeshare flight
        /// </summary>
        public string? Codeshare { get; set; }
        /// <summary>
        /// The departure IATA airport code
        /// </summary>
        public string Dep { get; set; }
        /// <summary>
        /// The destination IATA airport code
        /// </summary>
        public string Dest { get; set; }
        /// <summary>
        /// The departure DateTime in UTC
        /// </summary>
        public DateTime Std { get; set; }
        /// <summary>
        /// The arrival DateTime in UTC
        /// </summary>
        public DateTime Sta { get; set; }
        /// <summary>
        /// The local departure DateTime
        /// </summary>
        public DateTime StdLt { get; set; }
        /// <summary>
        /// The local arrival DateTime
        /// </summary>
        public DateTime StaLt { get; set; }
        /// <summary>
        /// The aircraft registration code
        /// </summary>
        public string AcRegistration { get; set; }
        /// <summary>
        /// The aircraft type
        /// </summary>
        public string AcType { get; set; }
        /// <summary>
        /// The aircraft owner
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// The tow weight of the plane in kilograms 
        /// </summary>
        public int? Tow { get; set; }
        /// <summary>
        /// General remarks for this flight
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// The Rotationnumber in a multilegged flight
        /// </summary>
        public string RotationNumber { get; set; }
        /// <summary>
        /// The departure IATA airport code
        /// </summary>
        public string? DepEff { get; set; }
        /// <summary>
        /// The destination IATA airport code
        /// </summary>
        public string? DestEff { get; set; }
        /// <summary>
        /// The departure DateTime in UTC
        /// </summary>
        public DateTime? StdEff { get; set; }
        /// <summary>
        /// The arrival DateTime in UTC
        /// </summary>
        public DateTime? StaEff { get; set; }
        /// <summary>
        /// The local departure DateTime
        /// </summary>
        public DateTime? StdLtEff { get; set; }
        /// <summary>
        /// The local arrival DateTime
        /// </summary>
        public DateTime? StaLtEff { get; set; }
        /// <summary>
        /// The departure gate
        /// </summary>
        public string? DepGateEff { get; set; }
        /// <summary>
        /// The destination gate
        /// </summary>
        public string? DestGateEff { get; set; }
        /// <summary>
        /// The effective take off time UTC
        /// </summary>
        public DateTime? TotEff { get; set; }
        /// <summary>
        /// The effective local take off time
        /// </summary>
        public DateTime? TotLtEff { get; set; }
        /// <summary>
        /// The effective landing time UTC
        /// </summary>
        public DateTime? LdtEff { get; set; }
        /// <summary>
        /// The effective local landing time
        /// </summary>
        public DateTime? LdtLtEff { get; set; }
        /// <summary>
        /// The line of work of an aircraft
        /// </summary>
        public string? LineOfWork { get; set; }
        /// <summary>
        /// The operation suffix of a flight number
        /// </summary>
        public string? OperationalSuffix { get; set; }
        public string FkCreatedBy { get; set; }
        public string? FkUpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

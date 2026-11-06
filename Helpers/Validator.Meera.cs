using System;
using System.Collections.Generic;
using System.Text;

namespace ResQ
{
    // Meera's additions. Keep the original Validator.cs beside this file.
    internal static partial class Validator
    {
        // ---------- shelter and emergency directory ----------
        public static string? ValidateDirectoryEntry(
        string name, string kind, string area, string phone, string status)
        {
            if (IsBlank(name) || IsBlank(area) || IsBlank(phone))
                return "Enter the name, area and phone number.";
            if (kind is not ("Shelter" or "Emergency contact"))
                return "Choose Shelter or Emergency contact.";
            if (!IsValidDirectoryPhone(phone))
                return "Enter a valid phone or emergency number, for example 999.";
            if (kind == "Shelter" && status is not ("Open" or "Closed"))
                return "A shelter must be Open or Closed.";
            if (kind == "Emergency contact" && status != "Active")
                return "An emergency contact must be Active.";
            return null;
        }
        // ---------- area risk ----------
        public static string? ValidateAreaRisk(string area, string riskLevel, string? note)
        {
            if (IsBlank(area)) return "Choose an area.";
            if (riskLevel is not ("Low" or "Medium" or "High"))
                return "Choose Low, Medium or High risk.";
            return null;
        }
        // ---------- incident report and administrator review ----------
        public static string? ValidateIncident(
        string hazardType, string location, string priority, string? description)
        {
            if (hazardType is not ("Fallen tree" or "Blocked road" or "Flooding"))
                return "Choose a hazard type.";
            if (IsBlank(location)) return "Enter the incident location.";
            if (priority is not ("Low" or "Medium" or "High"))
                return "Choose Low, Medium or High priority.";
            return null;
        }
            public static string? ValidateIncidentReview(string reviewStatus)
        {
            if (reviewStatus is not ("Verified" or "Rejected"))
                return "Choose Verified or Rejected.";
            return null;
        }
        // ---------- request form and volunteer progress ----------
        public static string? ValidateRequest(
        string helpType, string location, int peopleCount, string? mobility,
        string priority, string? extraInfo)
        {
            if (helpType is not ("Evacuation" or "Mobility support" or
            "Safety check-in" or "Supplies"))
                return "Choose a help type.";
            if (IsBlank(location)) return "Enter the request location.";
            if (peopleCount < 1) return "People count must be at least 1.";
            if (priority is not ("Low" or "Medium" or "High"))
                return "Choose Low, Medium or High priority.";
            return null;
        }
        public static string? ValidateRequestStatus(string newStatus, string? note)
        {
            if (newStatus is not ("In Progress" or "Safe / Evacuated" or "Completed"))
                return "Choose In Progress, Safe / Evacuated or Completed.";
            return null;
        }
    }
}


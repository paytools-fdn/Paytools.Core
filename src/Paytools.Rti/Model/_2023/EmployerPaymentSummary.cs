﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace Paytools.Rti.Model._2023 {
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummary_TelephoneStructure {
        
        private string numberField;
        
        private string extensionField;
        
        private EmployerPaymentSummary_WorkHomeType typeField;
        
        private bool typeFieldSpecified;
        
        private EmployerPaymentSummary_YesNoType mobileField;
        
        private bool mobileFieldSpecified;
        
        private EmployerPaymentSummary_YesNoType preferredField;
        
        private bool preferredFieldSpecified;
        
        /// <remarks/>
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public string Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmployerPaymentSummary_WorkHomeType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmployerPaymentSummary_YesNoType Mobile {
            get {
                return this.mobileField;
            }
            set {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MobileSpecified {
            get {
                return this.mobileFieldSpecified;
            }
            set {
                this.mobileFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmployerPaymentSummary_YesNoType Preferred {
            get {
                return this.preferredField;
            }
            set {
                this.preferredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferredSpecified {
            get {
                return this.preferredFieldSpecified;
            }
            set {
                this.preferredFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public enum EmployerPaymentSummary_WorkHomeType {
        
        /// <remarks/>
        home,
        
        /// <remarks/>
        work,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public enum EmployerPaymentSummary_YesNoType {
        
        /// <remarks/>
        no,
        
        /// <remarks/>
        yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummary_ContactDetailsStructure {
        
        private EmployerPaymentSummary_ContactDetailsStructureName nameField;
        
        private EmployerPaymentSummary_ContactDetailsStructureEmail[] emailField;
        
        private EmployerPaymentSummary_TelephoneStructure[] telephoneField;
        
        private EmployerPaymentSummary_TelephoneStructure[] faxField;
        
        /// <remarks/>
        public EmployerPaymentSummary_ContactDetailsStructureName Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public EmployerPaymentSummary_ContactDetailsStructureEmail[] Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public EmployerPaymentSummary_TelephoneStructure[] Telephone {
            get {
                return this.telephoneField;
            }
            set {
                this.telephoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fax")]
        public EmployerPaymentSummary_TelephoneStructure[] Fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummary_ContactDetailsStructureName {
        
        private string ttlField;
        
        private string[] foreField;
        
        private string surField;
        
        /// <remarks/>
        public string Ttl {
            get {
                return this.ttlField;
            }
            set {
                this.ttlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fore")]
        public string[] Fore {
            get {
                return this.foreField;
            }
            set {
                this.foreField = value;
            }
        }
        
        /// <remarks/>
        public string Sur {
            get {
                return this.surField;
            }
            set {
                this.surField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummary_ContactDetailsStructureEmail {
        
        private EmployerPaymentSummary_WorkHomeType typeField;
        
        private bool typeFieldSpecified;
        
        private EmployerPaymentSummary_YesNoType preferredField;
        
        private bool preferredFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmployerPaymentSummary_WorkHomeType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EmployerPaymentSummary_YesNoType Preferred {
            get {
                return this.preferredField;
            }
            set {
                this.preferredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferredSpecified {
            get {
                return this.preferredFieldSpecified;
            }
            set {
                this.preferredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1", IsNullable=false)]
    public partial class EmployerPaymentSummary {
        
        private EmployerPaymentSummaryEmpRefs empRefsField;
        
        private EmployerPaymentSummary_YesType noPaymentForPeriodField;
        
        private EmployerPaymentSummaryNoPaymentDates noPaymentDatesField;
        
        private EmployerPaymentSummaryPeriodOfInactivity periodOfInactivityField;
        
        private EmployerPaymentSummary_YesNoType empAllceIndField;
        
        private bool empAllceIndFieldSpecified;
        
        private EmployerPaymentSummaryDeMinimisStateAid deMinimisStateAidField;
        
        private EmployerPaymentSummaryRecoverableAmountsYTD recoverableAmountsYTDField;
        
        private EmployerPaymentSummaryApprenticeshipLevy apprenticeshipLevyField;
        
        private EmployerPaymentSummaryAccount accountField;
        
        private string relatedTaxYearField;
        
        private EmployerPaymentSummaryFinalSubmission finalSubmissionField;
        
        /// <remarks/>
        public EmployerPaymentSummaryEmpRefs EmpRefs {
            get {
                return this.empRefsField;
            }
            set {
                this.empRefsField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType NoPaymentForPeriod {
            get {
                return this.noPaymentForPeriodField;
            }
            set {
                this.noPaymentForPeriodField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryNoPaymentDates NoPaymentDates {
            get {
                return this.noPaymentDatesField;
            }
            set {
                this.noPaymentDatesField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryPeriodOfInactivity PeriodOfInactivity {
            get {
                return this.periodOfInactivityField;
            }
            set {
                this.periodOfInactivityField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesNoType EmpAllceInd {
            get {
                return this.empAllceIndField;
            }
            set {
                this.empAllceIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmpAllceIndSpecified {
            get {
                return this.empAllceIndFieldSpecified;
            }
            set {
                this.empAllceIndFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryDeMinimisStateAid DeMinimisStateAid {
            get {
                return this.deMinimisStateAidField;
            }
            set {
                this.deMinimisStateAidField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryRecoverableAmountsYTD RecoverableAmountsYTD {
            get {
                return this.recoverableAmountsYTDField;
            }
            set {
                this.recoverableAmountsYTDField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryApprenticeshipLevy ApprenticeshipLevy {
            get {
                return this.apprenticeshipLevyField;
            }
            set {
                this.apprenticeshipLevyField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryAccount Account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }
        
        /// <remarks/>
        public string RelatedTaxYear {
            get {
                return this.relatedTaxYearField;
            }
            set {
                this.relatedTaxYearField = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummaryFinalSubmission FinalSubmission {
            get {
                return this.finalSubmissionField;
            }
            set {
                this.finalSubmissionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryEmpRefs {
        
        private string officeNoField;
        
        private string payeRefField;
        
        private string aORefField;
        
        private string cOTAXRefField;
        
        /// <remarks/>
        public string OfficeNo {
            get {
                return this.officeNoField;
            }
            set {
                this.officeNoField = value;
            }
        }
        
        /// <remarks/>
        public string PayeRef {
            get {
                return this.payeRefField;
            }
            set {
                this.payeRefField = value;
            }
        }
        
        /// <remarks/>
        public string AORef {
            get {
                return this.aORefField;
            }
            set {
                this.aORefField = value;
            }
        }
        
        /// <remarks/>
        public string COTAXRef {
            get {
                return this.cOTAXRefField;
            }
            set {
                this.cOTAXRefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public enum EmployerPaymentSummary_YesType {
        
        /// <remarks/>
        yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryNoPaymentDates {
        
        private System.DateTime fromField;
        
        private System.DateTime toField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime To {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryPeriodOfInactivity {
        
        private System.DateTime fromField;
        
        private System.DateTime toField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime To {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryDeMinimisStateAid {
        
        private EmployerPaymentSummary_YesType agriField;
        
        private bool agriFieldSpecified;
        
        private EmployerPaymentSummary_YesType fisheriesAquaField;
        
        private bool fisheriesAquaFieldSpecified;
        
        private EmployerPaymentSummary_YesType roadTransField;
        
        private bool roadTransFieldSpecified;
        
        private EmployerPaymentSummary_YesType industField;
        
        private bool industFieldSpecified;
        
        private EmployerPaymentSummary_YesType naField;
        
        private bool naFieldSpecified;
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType Agri {
            get {
                return this.agriField;
            }
            set {
                this.agriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgriSpecified {
            get {
                return this.agriFieldSpecified;
            }
            set {
                this.agriFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType FisheriesAqua {
            get {
                return this.fisheriesAquaField;
            }
            set {
                this.fisheriesAquaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FisheriesAquaSpecified {
            get {
                return this.fisheriesAquaFieldSpecified;
            }
            set {
                this.fisheriesAquaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType RoadTrans {
            get {
                return this.roadTransField;
            }
            set {
                this.roadTransField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoadTransSpecified {
            get {
                return this.roadTransFieldSpecified;
            }
            set {
                this.roadTransFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType Indust {
            get {
                return this.industField;
            }
            set {
                this.industField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndustSpecified {
            get {
                return this.industFieldSpecified;
            }
            set {
                this.industFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType NA {
            get {
                return this.naField;
            }
            set {
                this.naField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NASpecified {
            get {
                return this.naFieldSpecified;
            }
            set {
                this.naFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryRecoverableAmountsYTD {
        
        private string taxMonthField;
        
        private decimal sMPRecoveredField;
        
        private bool sMPRecoveredFieldSpecified;
        
        private decimal sPPRecoveredField;
        
        private bool sPPRecoveredFieldSpecified;
        
        private decimal sAPRecoveredField;
        
        private bool sAPRecoveredFieldSpecified;
        
        private decimal shPPRecoveredField;
        
        private bool shPPRecoveredFieldSpecified;
        
        private decimal sPBPRecoveredField;
        
        private bool sPBPRecoveredFieldSpecified;
        
        private decimal nICCompensationOnSMPField;
        
        private bool nICCompensationOnSMPFieldSpecified;
        
        private decimal nICCompensationOnSPPField;
        
        private bool nICCompensationOnSPPFieldSpecified;
        
        private decimal nICCompensationOnSAPField;
        
        private bool nICCompensationOnSAPFieldSpecified;
        
        private decimal nICCompensationOnShPPField;
        
        private bool nICCompensationOnShPPFieldSpecified;
        
        private decimal nICCompensationOnSPBPField;
        
        private bool nICCompensationOnSPBPFieldSpecified;
        
        private decimal cISDeductionsSufferedField;
        
        private bool cISDeductionsSufferedFieldSpecified;
        
        /// <remarks/>
        public string TaxMonth {
            get {
                return this.taxMonthField;
            }
            set {
                this.taxMonthField = value;
            }
        }
        
        /// <remarks/>
        public decimal SMPRecovered {
            get {
                return this.sMPRecoveredField;
            }
            set {
                this.sMPRecoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SMPRecoveredSpecified {
            get {
                return this.sMPRecoveredFieldSpecified;
            }
            set {
                this.sMPRecoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal SPPRecovered {
            get {
                return this.sPPRecoveredField;
            }
            set {
                this.sPPRecoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SPPRecoveredSpecified {
            get {
                return this.sPPRecoveredFieldSpecified;
            }
            set {
                this.sPPRecoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal SAPRecovered {
            get {
                return this.sAPRecoveredField;
            }
            set {
                this.sAPRecoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SAPRecoveredSpecified {
            get {
                return this.sAPRecoveredFieldSpecified;
            }
            set {
                this.sAPRecoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal ShPPRecovered {
            get {
                return this.shPPRecoveredField;
            }
            set {
                this.shPPRecoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShPPRecoveredSpecified {
            get {
                return this.shPPRecoveredFieldSpecified;
            }
            set {
                this.shPPRecoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal SPBPRecovered {
            get {
                return this.sPBPRecoveredField;
            }
            set {
                this.sPBPRecoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SPBPRecoveredSpecified {
            get {
                return this.sPBPRecoveredFieldSpecified;
            }
            set {
                this.sPBPRecoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NICCompensationOnSMP {
            get {
                return this.nICCompensationOnSMPField;
            }
            set {
                this.nICCompensationOnSMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NICCompensationOnSMPSpecified {
            get {
                return this.nICCompensationOnSMPFieldSpecified;
            }
            set {
                this.nICCompensationOnSMPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NICCompensationOnSPP {
            get {
                return this.nICCompensationOnSPPField;
            }
            set {
                this.nICCompensationOnSPPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NICCompensationOnSPPSpecified {
            get {
                return this.nICCompensationOnSPPFieldSpecified;
            }
            set {
                this.nICCompensationOnSPPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NICCompensationOnSAP {
            get {
                return this.nICCompensationOnSAPField;
            }
            set {
                this.nICCompensationOnSAPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NICCompensationOnSAPSpecified {
            get {
                return this.nICCompensationOnSAPFieldSpecified;
            }
            set {
                this.nICCompensationOnSAPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NICCompensationOnShPP {
            get {
                return this.nICCompensationOnShPPField;
            }
            set {
                this.nICCompensationOnShPPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NICCompensationOnShPPSpecified {
            get {
                return this.nICCompensationOnShPPFieldSpecified;
            }
            set {
                this.nICCompensationOnShPPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal NICCompensationOnSPBP {
            get {
                return this.nICCompensationOnSPBPField;
            }
            set {
                this.nICCompensationOnSPBPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NICCompensationOnSPBPSpecified {
            get {
                return this.nICCompensationOnSPBPFieldSpecified;
            }
            set {
                this.nICCompensationOnSPBPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal CISDeductionsSuffered {
            get {
                return this.cISDeductionsSufferedField;
            }
            set {
                this.cISDeductionsSufferedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CISDeductionsSufferedSpecified {
            get {
                return this.cISDeductionsSufferedFieldSpecified;
            }
            set {
                this.cISDeductionsSufferedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryApprenticeshipLevy {
        
        private decimal levyDueYTDField;
        
        private string taxMonthField;
        
        private decimal annualAllceField;
        
        /// <remarks/>
        public decimal LevyDueYTD {
            get {
                return this.levyDueYTDField;
            }
            set {
                this.levyDueYTDField = value;
            }
        }
        
        /// <remarks/>
        public string TaxMonth {
            get {
                return this.taxMonthField;
            }
            set {
                this.taxMonthField = value;
            }
        }
        
        /// <remarks/>
        public decimal AnnualAllce {
            get {
                return this.annualAllceField;
            }
            set {
                this.annualAllceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryAccount {
        
        private string accountHoldersNameField;
        
        private string accountNoField;
        
        private string sortCodeField;
        
        private string buildingSocRefField;
        
        /// <remarks/>
        public string AccountHoldersName {
            get {
                return this.accountHoldersNameField;
            }
            set {
                this.accountHoldersNameField = value;
            }
        }
        
        /// <remarks/>
        public string AccountNo {
            get {
                return this.accountNoField;
            }
            set {
                this.accountNoField = value;
            }
        }
        
        /// <remarks/>
        public string SortCode {
            get {
                return this.sortCodeField;
            }
            set {
                this.sortCodeField = value;
            }
        }
        
        /// <remarks/>
        public string BuildingSocRef {
            get {
                return this.buildingSocRefField;
            }
            set {
                this.buildingSocRefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.govtalk.gov.uk/taxation/PAYE/RTI/EmployerPaymentSummary/22-23/1")]
    public partial class EmployerPaymentSummaryFinalSubmission {
        
        private EmployerPaymentSummary_YesType becauseSchemeCeasedField;
        
        private bool becauseSchemeCeasedFieldSpecified;
        
        private System.DateTime dateSchemeCeasedField;
        
        private bool dateSchemeCeasedFieldSpecified;
        
        private EmployerPaymentSummary_YesType forYearField;
        
        private bool forYearFieldSpecified;
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType BecauseSchemeCeased {
            get {
                return this.becauseSchemeCeasedField;
            }
            set {
                this.becauseSchemeCeasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BecauseSchemeCeasedSpecified {
            get {
                return this.becauseSchemeCeasedFieldSpecified;
            }
            set {
                this.becauseSchemeCeasedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DateSchemeCeased {
            get {
                return this.dateSchemeCeasedField;
            }
            set {
                this.dateSchemeCeasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSchemeCeasedSpecified {
            get {
                return this.dateSchemeCeasedFieldSpecified;
            }
            set {
                this.dateSchemeCeasedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public EmployerPaymentSummary_YesType ForYear {
            get {
                return this.forYearField;
            }
            set {
                this.forYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForYearSpecified {
            get {
                return this.forYearFieldSpecified;
            }
            set {
                this.forYearFieldSpecified = value;
            }
        }
    }
}


/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class FlexQueryResponse
{

    private FlexQueryResponseFlexStatements flexStatementsField;

    private string queryNameField;

    private string typeField;

    /// <remarks/>
    public FlexQueryResponseFlexStatements FlexStatements
    {
        get
        {
            return this.flexStatementsField;
        }
        set
        {
            this.flexStatementsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string queryName
    {
        get
        {
            return this.queryNameField;
        }
        set
        {
            this.queryNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatements
{

    private FlexQueryResponseFlexStatementsFlexStatement flexStatementField;

    private byte countField;

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatement FlexStatement
    {
        get
        {
            return this.flexStatementField;
        }
        set
        {
            this.flexStatementField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatement
{

    private FlexQueryResponseFlexStatementsFlexStatementAccountInformation accountInformationField;

    private FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase[] equitySummaryInBaseField;

    private FlexQueryResponseFlexStatementsFlexStatementChangeInNAV changeInNAVField;

    private object fIFOPerformanceSummaryInBaseField;

    private FlexQueryResponseFlexStatementsFlexStatementMTMPerformanceSummaryUnderlying[] mTMPerformanceSummaryInBaseField;

    private object mTDYTDPerformanceSummaryField;

    private FlexQueryResponseFlexStatementsFlexStatementCashReport cashReportField;

    private object fdicInsuredDepositsByBankField;

    private FlexQueryResponseFlexStatementsFlexStatementStatementOfFundsLine[] stmtFundsField;

    private FlexQueryResponseFlexStatementsFlexStatementChangeInPositionValue[] changeInPositionValuesField;

    private object openPositionsField;

    private object complexPositionsField;

    private object netStockPositionSummaryField;

    private object fxPositionsField;

    private FlexQueryResponseFlexStatementsFlexStatementTrade[] tradesField;

    private object transactionTaxesField;

    private FlexQueryResponseFlexStatementsFlexStatementOptionEAE[] optionEAEField;

    private object pendingExcercisesField;

    private object tradeTransfersField;

    private object fxTransactionsField;

    private object unsettledTransfersField;

    private object unbookedTradesField;

    private object routingCommissionsField;

    private FlexQueryResponseFlexStatementsFlexStatementUnbundledCommissionDetail[] unbundledCommissionDetailsField;

    private FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition[] priorPeriodPositionsField;

    private object iBGNoteTransactionsField;

    private object corporateActionsField;

    private FlexQueryResponseFlexStatementsFlexStatementCashTransaction[] cashTransactionsField;

    private object cFDChargesField;

    private FlexQueryResponseFlexStatementsFlexStatementInterestAccruals interestAccrualsField;

    private object sLBOpenContractsField;

    private object sLBActivitiesField;

    private object sLBFeesField;

    private object transfersField;

    private FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual[] changeInDividendAccrualsField;

    private FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual[] openDividendAccrualsField;

    private FlexQueryResponseFlexStatementsFlexStatementSecurityInfo[] securitiesInfoField;

    private string accountIdField;

    private uint fromDateField;

    private uint toDateField;

    private string periodField;

    private string whenGeneratedField;

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementAccountInformation AccountInformation
    {
        get
        {
            return this.accountInformationField;
        }
        set
        {
            this.accountInformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("EquitySummaryByReportDateInBase", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase[] EquitySummaryInBase
    {
        get
        {
            return this.equitySummaryInBaseField;
        }
        set
        {
            this.equitySummaryInBaseField = value;
        }
    }

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementChangeInNAV ChangeInNAV
    {
        get
        {
            return this.changeInNAVField;
        }
        set
        {
            this.changeInNAVField = value;
        }
    }

    /// <remarks/>
    public object FIFOPerformanceSummaryInBase
    {
        get
        {
            return this.fIFOPerformanceSummaryInBaseField;
        }
        set
        {
            this.fIFOPerformanceSummaryInBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MTMPerformanceSummaryUnderlying", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementMTMPerformanceSummaryUnderlying[] MTMPerformanceSummaryInBase
    {
        get
        {
            return this.mTMPerformanceSummaryInBaseField;
        }
        set
        {
            this.mTMPerformanceSummaryInBaseField = value;
        }
    }

    /// <remarks/>
    public object MTDYTDPerformanceSummary
    {
        get
        {
            return this.mTDYTDPerformanceSummaryField;
        }
        set
        {
            this.mTDYTDPerformanceSummaryField = value;
        }
    }

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementCashReport CashReport
    {
        get
        {
            return this.cashReportField;
        }
        set
        {
            this.cashReportField = value;
        }
    }

    /// <remarks/>
    public object FdicInsuredDepositsByBank
    {
        get
        {
            return this.fdicInsuredDepositsByBankField;
        }
        set
        {
            this.fdicInsuredDepositsByBankField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("StatementOfFundsLine", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementStatementOfFundsLine[] StmtFunds
    {
        get
        {
            return this.stmtFundsField;
        }
        set
        {
            this.stmtFundsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ChangeInPositionValue", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementChangeInPositionValue[] ChangeInPositionValues
    {
        get
        {
            return this.changeInPositionValuesField;
        }
        set
        {
            this.changeInPositionValuesField = value;
        }
    }

    /// <remarks/>
    public object OpenPositions
    {
        get
        {
            return this.openPositionsField;
        }
        set
        {
            this.openPositionsField = value;
        }
    }

    /// <remarks/>
    public object ComplexPositions
    {
        get
        {
            return this.complexPositionsField;
        }
        set
        {
            this.complexPositionsField = value;
        }
    }

    /// <remarks/>
    public object NetStockPositionSummary
    {
        get
        {
            return this.netStockPositionSummaryField;
        }
        set
        {
            this.netStockPositionSummaryField = value;
        }
    }

    /// <remarks/>
    public object FxPositions
    {
        get
        {
            return this.fxPositionsField;
        }
        set
        {
            this.fxPositionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Trade", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementTrade[] Trades
    {
        get
        {
            return this.tradesField;
        }
        set
        {
            this.tradesField = value;
        }
    }

    /// <remarks/>
    public object TransactionTaxes
    {
        get
        {
            return this.transactionTaxesField;
        }
        set
        {
            this.transactionTaxesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OptionEAE", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementOptionEAE[] OptionEAE
    {
        get
        {
            return this.optionEAEField;
        }
        set
        {
            this.optionEAEField = value;
        }
    }

    /// <remarks/>
    public object PendingExcercises
    {
        get
        {
            return this.pendingExcercisesField;
        }
        set
        {
            this.pendingExcercisesField = value;
        }
    }

    /// <remarks/>
    public object TradeTransfers
    {
        get
        {
            return this.tradeTransfersField;
        }
        set
        {
            this.tradeTransfersField = value;
        }
    }

    /// <remarks/>
    public object FxTransactions
    {
        get
        {
            return this.fxTransactionsField;
        }
        set
        {
            this.fxTransactionsField = value;
        }
    }

    /// <remarks/>
    public object UnsettledTransfers
    {
        get
        {
            return this.unsettledTransfersField;
        }
        set
        {
            this.unsettledTransfersField = value;
        }
    }

    /// <remarks/>
    public object UnbookedTrades
    {
        get
        {
            return this.unbookedTradesField;
        }
        set
        {
            this.unbookedTradesField = value;
        }
    }

    /// <remarks/>
    public object RoutingCommissions
    {
        get
        {
            return this.routingCommissionsField;
        }
        set
        {
            this.routingCommissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("UnbundledCommissionDetail", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementUnbundledCommissionDetail[] UnbundledCommissionDetails
    {
        get
        {
            return this.unbundledCommissionDetailsField;
        }
        set
        {
            this.unbundledCommissionDetailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("PriorPeriodPosition", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition[] PriorPeriodPositions
    {
        get
        {
            return this.priorPeriodPositionsField;
        }
        set
        {
            this.priorPeriodPositionsField = value;
        }
    }

    /// <remarks/>
    public object IBGNoteTransactions
    {
        get
        {
            return this.iBGNoteTransactionsField;
        }
        set
        {
            this.iBGNoteTransactionsField = value;
        }
    }

    /// <remarks/>
    public object CorporateActions
    {
        get
        {
            return this.corporateActionsField;
        }
        set
        {
            this.corporateActionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CashTransaction", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementCashTransaction[] CashTransactions
    {
        get
        {
            return this.cashTransactionsField;
        }
        set
        {
            this.cashTransactionsField = value;
        }
    }

    /// <remarks/>
    public object CFDCharges
    {
        get
        {
            return this.cFDChargesField;
        }
        set
        {
            this.cFDChargesField = value;
        }
    }

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementInterestAccruals InterestAccruals
    {
        get
        {
            return this.interestAccrualsField;
        }
        set
        {
            this.interestAccrualsField = value;
        }
    }

    /// <remarks/>
    public object SLBOpenContracts
    {
        get
        {
            return this.sLBOpenContractsField;
        }
        set
        {
            this.sLBOpenContractsField = value;
        }
    }

    /// <remarks/>
    public object SLBActivities
    {
        get
        {
            return this.sLBActivitiesField;
        }
        set
        {
            this.sLBActivitiesField = value;
        }
    }

    /// <remarks/>
    public object SLBFees
    {
        get
        {
            return this.sLBFeesField;
        }
        set
        {
            this.sLBFeesField = value;
        }
    }

    /// <remarks/>
    public object Transfers
    {
        get
        {
            return this.transfersField;
        }
        set
        {
            this.transfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ChangeInDividendAccrual", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual[] ChangeInDividendAccruals
    {
        get
        {
            return this.changeInDividendAccrualsField;
        }
        set
        {
            this.changeInDividendAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OpenDividendAccrual", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual[] OpenDividendAccruals
    {
        get
        {
            return this.openDividendAccrualsField;
        }
        set
        {
            this.openDividendAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("SecurityInfo", IsNullable = false)]
    public FlexQueryResponseFlexStatementsFlexStatementSecurityInfo[] SecuritiesInfo
    {
        get
        {
            return this.securitiesInfoField;
        }
        set
        {
            this.securitiesInfoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint fromDate
    {
        get
        {
            return this.fromDateField;
        }
        set
        {
            this.fromDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint toDate
    {
        get
        {
            return this.toDateField;
        }
        set
        {
            this.toDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string period
    {
        get
        {
            return this.periodField;
        }
        set
        {
            this.periodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string whenGenerated
    {
        get
        {
            return this.whenGeneratedField;
        }
        set
        {
            this.whenGeneratedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementAccountInformation
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private string nameField;

    private string accountTypeField;

    private string customerTypeField;

    private string accountCapabilitiesField;

    private string tradingPermissionsField;

    private string registeredRepNameField;

    private string registeredRepPhoneField;

    private uint dateOpenedField;

    private uint dateFundedField;

    private string dateClosedField;

    private string streetField;

    private string street2Field;

    private string cityField;

    private string stateField;

    private string countryField;

    private ushort postalCodeField;

    private string streetResidentialAddressField;

    private string street2ResidentialAddressField;

    private string cityResidentialAddressField;

    private string stateResidentialAddressField;

    private string countryResidentialAddressField;

    private ushort postalCodeResidentialAddressField;

    private string masterNameField;

    private string ibEntityField;

    private string primaryEmailField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountType
    {
        get
        {
            return this.accountTypeField;
        }
        set
        {
            this.accountTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string customerType
    {
        get
        {
            return this.customerTypeField;
        }
        set
        {
            this.customerTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountCapabilities
    {
        get
        {
            return this.accountCapabilitiesField;
        }
        set
        {
            this.accountCapabilitiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tradingPermissions
    {
        get
        {
            return this.tradingPermissionsField;
        }
        set
        {
            this.tradingPermissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string registeredRepName
    {
        get
        {
            return this.registeredRepNameField;
        }
        set
        {
            this.registeredRepNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string registeredRepPhone
    {
        get
        {
            return this.registeredRepPhoneField;
        }
        set
        {
            this.registeredRepPhoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint dateOpened
    {
        get
        {
            return this.dateOpenedField;
        }
        set
        {
            this.dateOpenedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint dateFunded
    {
        get
        {
            return this.dateFundedField;
        }
        set
        {
            this.dateFundedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string dateClosed
    {
        get
        {
            return this.dateClosedField;
        }
        set
        {
            this.dateClosedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string street2
    {
        get
        {
            return this.street2Field;
        }
        set
        {
            this.street2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort postalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string streetResidentialAddress
    {
        get
        {
            return this.streetResidentialAddressField;
        }
        set
        {
            this.streetResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string street2ResidentialAddress
    {
        get
        {
            return this.street2ResidentialAddressField;
        }
        set
        {
            this.street2ResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cityResidentialAddress
    {
        get
        {
            return this.cityResidentialAddressField;
        }
        set
        {
            this.cityResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stateResidentialAddress
    {
        get
        {
            return this.stateResidentialAddressField;
        }
        set
        {
            this.stateResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string countryResidentialAddress
    {
        get
        {
            return this.countryResidentialAddressField;
        }
        set
        {
            this.countryResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort postalCodeResidentialAddress
    {
        get
        {
            return this.postalCodeResidentialAddressField;
        }
        set
        {
            this.postalCodeResidentialAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string masterName
    {
        get
        {
            return this.masterNameField;
        }
        set
        {
            this.masterNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ibEntity
    {
        get
        {
            return this.ibEntityField;
        }
        set
        {
            this.ibEntityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string primaryEmail
    {
        get
        {
            return this.primaryEmailField;
        }
        set
        {
            this.primaryEmailField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementEquitySummaryByReportDateInBase
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private uint reportDateField;

    private decimal cashField;

    private decimal cashLongField;

    private byte cashShortField;

    private byte slbCashCollateralField;

    private byte slbCashCollateralLongField;

    private byte slbCashCollateralShortField;

    private decimal stockField;

    private decimal stockLongField;

    private byte stockShortField;

    private byte slbDirectSecuritiesBorrowedField;

    private byte slbDirectSecuritiesBorrowedLongField;

    private byte slbDirectSecuritiesBorrowedShortField;

    private byte slbDirectSecuritiesLentField;

    private byte slbDirectSecuritiesLentLongField;

    private byte slbDirectSecuritiesLentShortField;

    private decimal optionsField;

    private byte optionsLongField;

    private decimal optionsShortField;

    private byte commoditiesField;

    private byte commoditiesLongField;

    private byte commoditiesShortField;

    private byte bondsField;

    private byte bondsLongField;

    private byte bondsShortField;

    private byte notesField;

    private byte notesLongField;

    private byte notesShortField;

    private byte fundsField;

    private byte fundsLongField;

    private byte fundsShortField;

    private decimal interestAccrualsField;

    private byte interestAccrualsLongField;

    private decimal interestAccrualsShortField;

    private byte softDollarsField;

    private byte softDollarsLongField;

    private byte softDollarsShortField;

    private byte forexCfdUnrealizedPlField;

    private byte forexCfdUnrealizedPlLongField;

    private byte forexCfdUnrealizedPlShortField;

    private decimal dividendAccrualsField;

    private decimal dividendAccrualsLongField;

    private byte dividendAccrualsShortField;

    private byte fdicInsuredBankSweepAccountField;

    private byte fdicInsuredBankSweepAccountLongField;

    private byte fdicInsuredBankSweepAccountShortField;

    private byte fdicInsuredAccountInterestAccrualsField;

    private byte fdicInsuredAccountInterestAccrualsLongField;

    private byte fdicInsuredAccountInterestAccrualsShortField;

    private decimal totalField;

    private decimal totalLongField;

    private decimal totalShortField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cash
    {
        get
        {
            return this.cashField;
        }
        set
        {
            this.cashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cashLong
    {
        get
        {
            return this.cashLongField;
        }
        set
        {
            this.cashLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cashShort
    {
        get
        {
            return this.cashShortField;
        }
        set
        {
            this.cashShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbCashCollateral
    {
        get
        {
            return this.slbCashCollateralField;
        }
        set
        {
            this.slbCashCollateralField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbCashCollateralLong
    {
        get
        {
            return this.slbCashCollateralLongField;
        }
        set
        {
            this.slbCashCollateralLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbCashCollateralShort
    {
        get
        {
            return this.slbCashCollateralShortField;
        }
        set
        {
            this.slbCashCollateralShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal stock
    {
        get
        {
            return this.stockField;
        }
        set
        {
            this.stockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal stockLong
    {
        get
        {
            return this.stockLongField;
        }
        set
        {
            this.stockLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte stockShort
    {
        get
        {
            return this.stockShortField;
        }
        set
        {
            this.stockShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesBorrowed
    {
        get
        {
            return this.slbDirectSecuritiesBorrowedField;
        }
        set
        {
            this.slbDirectSecuritiesBorrowedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesBorrowedLong
    {
        get
        {
            return this.slbDirectSecuritiesBorrowedLongField;
        }
        set
        {
            this.slbDirectSecuritiesBorrowedLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesBorrowedShort
    {
        get
        {
            return this.slbDirectSecuritiesBorrowedShortField;
        }
        set
        {
            this.slbDirectSecuritiesBorrowedShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesLent
    {
        get
        {
            return this.slbDirectSecuritiesLentField;
        }
        set
        {
            this.slbDirectSecuritiesLentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesLentLong
    {
        get
        {
            return this.slbDirectSecuritiesLentLongField;
        }
        set
        {
            this.slbDirectSecuritiesLentLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte slbDirectSecuritiesLentShort
    {
        get
        {
            return this.slbDirectSecuritiesLentShortField;
        }
        set
        {
            this.slbDirectSecuritiesLentShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal options
    {
        get
        {
            return this.optionsField;
        }
        set
        {
            this.optionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte optionsLong
    {
        get
        {
            return this.optionsLongField;
        }
        set
        {
            this.optionsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal optionsShort
    {
        get
        {
            return this.optionsShortField;
        }
        set
        {
            this.optionsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte commodities
    {
        get
        {
            return this.commoditiesField;
        }
        set
        {
            this.commoditiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte commoditiesLong
    {
        get
        {
            return this.commoditiesLongField;
        }
        set
        {
            this.commoditiesLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte commoditiesShort
    {
        get
        {
            return this.commoditiesShortField;
        }
        set
        {
            this.commoditiesShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bonds
    {
        get
        {
            return this.bondsField;
        }
        set
        {
            this.bondsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bondsLong
    {
        get
        {
            return this.bondsLongField;
        }
        set
        {
            this.bondsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bondsShort
    {
        get
        {
            return this.bondsShortField;
        }
        set
        {
            this.bondsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte notesLong
    {
        get
        {
            return this.notesLongField;
        }
        set
        {
            this.notesLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte notesShort
    {
        get
        {
            return this.notesShortField;
        }
        set
        {
            this.notesShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte funds
    {
        get
        {
            return this.fundsField;
        }
        set
        {
            this.fundsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fundsLong
    {
        get
        {
            return this.fundsLongField;
        }
        set
        {
            this.fundsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fundsShort
    {
        get
        {
            return this.fundsShortField;
        }
        set
        {
            this.fundsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal interestAccruals
    {
        get
        {
            return this.interestAccrualsField;
        }
        set
        {
            this.interestAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte interestAccrualsLong
    {
        get
        {
            return this.interestAccrualsLongField;
        }
        set
        {
            this.interestAccrualsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal interestAccrualsShort
    {
        get
        {
            return this.interestAccrualsShortField;
        }
        set
        {
            this.interestAccrualsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte softDollars
    {
        get
        {
            return this.softDollarsField;
        }
        set
        {
            this.softDollarsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte softDollarsLong
    {
        get
        {
            return this.softDollarsLongField;
        }
        set
        {
            this.softDollarsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte softDollarsShort
    {
        get
        {
            return this.softDollarsShortField;
        }
        set
        {
            this.softDollarsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte forexCfdUnrealizedPl
    {
        get
        {
            return this.forexCfdUnrealizedPlField;
        }
        set
        {
            this.forexCfdUnrealizedPlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte forexCfdUnrealizedPlLong
    {
        get
        {
            return this.forexCfdUnrealizedPlLongField;
        }
        set
        {
            this.forexCfdUnrealizedPlLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte forexCfdUnrealizedPlShort
    {
        get
        {
            return this.forexCfdUnrealizedPlShortField;
        }
        set
        {
            this.forexCfdUnrealizedPlShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal dividendAccruals
    {
        get
        {
            return this.dividendAccrualsField;
        }
        set
        {
            this.dividendAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal dividendAccrualsLong
    {
        get
        {
            return this.dividendAccrualsLongField;
        }
        set
        {
            this.dividendAccrualsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte dividendAccrualsShort
    {
        get
        {
            return this.dividendAccrualsShortField;
        }
        set
        {
            this.dividendAccrualsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredBankSweepAccount
    {
        get
        {
            return this.fdicInsuredBankSweepAccountField;
        }
        set
        {
            this.fdicInsuredBankSweepAccountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredBankSweepAccountLong
    {
        get
        {
            return this.fdicInsuredBankSweepAccountLongField;
        }
        set
        {
            this.fdicInsuredBankSweepAccountLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredBankSweepAccountShort
    {
        get
        {
            return this.fdicInsuredBankSweepAccountShortField;
        }
        set
        {
            this.fdicInsuredBankSweepAccountShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredAccountInterestAccruals
    {
        get
        {
            return this.fdicInsuredAccountInterestAccrualsField;
        }
        set
        {
            this.fdicInsuredAccountInterestAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredAccountInterestAccrualsLong
    {
        get
        {
            return this.fdicInsuredAccountInterestAccrualsLongField;
        }
        set
        {
            this.fdicInsuredAccountInterestAccrualsLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fdicInsuredAccountInterestAccrualsShort
    {
        get
        {
            return this.fdicInsuredAccountInterestAccrualsShortField;
        }
        set
        {
            this.fdicInsuredAccountInterestAccrualsShortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal totalLong
    {
        get
        {
            return this.totalLongField;
        }
        set
        {
            this.totalLongField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal totalShort
    {
        get
        {
            return this.totalShortField;
        }
        set
        {
            this.totalShortField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementChangeInNAV
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private uint fromDateField;

    private uint toDateField;

    private decimal startingValueField;

    private decimal mtmField;

    private byte realizedField;

    private byte changeInUnrealizedField;

    private byte costAdjustmentsField;

    private byte transferredPnlAdjustmentsField;

    private ushort depositsWithdrawalsField;

    private byte internalCashTransfersField;

    private byte assetTransfersField;

    private decimal dividendsField;

    private decimal withholdingTaxField;

    private byte withholding871mField;

    private byte withholdingTaxCollectedField;

    private decimal changeInDividendAccrualsField;

    private decimal interestField;

    private decimal changeInInterestAccrualsField;

    private byte advisorFeesField;

    private byte clientFeesField;

    private decimal otherFeesField;

    private byte feesReceivablesField;

    private decimal commissionsField;

    private byte commissionReceivablesField;

    private byte forexCommissionsField;

    private byte transactionTaxField;

    private byte taxReceivablesField;

    private byte salesTaxField;

    private byte softDollarsField;

    private byte netFxTradingField;

    private byte fxTranslationField;

    private byte linkingAdjustmentsField;

    private byte otherField;

    private decimal endingValueField;

    private decimal twrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint fromDate
    {
        get
        {
            return this.fromDateField;
        }
        set
        {
            this.fromDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint toDate
    {
        get
        {
            return this.toDateField;
        }
        set
        {
            this.toDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal startingValue
    {
        get
        {
            return this.startingValueField;
        }
        set
        {
            this.startingValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal mtm
    {
        get
        {
            return this.mtmField;
        }
        set
        {
            this.mtmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte realized
    {
        get
        {
            return this.realizedField;
        }
        set
        {
            this.realizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte changeInUnrealized
    {
        get
        {
            return this.changeInUnrealizedField;
        }
        set
        {
            this.changeInUnrealizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte costAdjustments
    {
        get
        {
            return this.costAdjustmentsField;
        }
        set
        {
            this.costAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte transferredPnlAdjustments
    {
        get
        {
            return this.transferredPnlAdjustmentsField;
        }
        set
        {
            this.transferredPnlAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort depositsWithdrawals
    {
        get
        {
            return this.depositsWithdrawalsField;
        }
        set
        {
            this.depositsWithdrawalsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte internalCashTransfers
    {
        get
        {
            return this.internalCashTransfersField;
        }
        set
        {
            this.internalCashTransfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte assetTransfers
    {
        get
        {
            return this.assetTransfersField;
        }
        set
        {
            this.assetTransfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal dividends
    {
        get
        {
            return this.dividendsField;
        }
        set
        {
            this.dividendsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal withholdingTax
    {
        get
        {
            return this.withholdingTaxField;
        }
        set
        {
            this.withholdingTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholding871m
    {
        get
        {
            return this.withholding871mField;
        }
        set
        {
            this.withholding871mField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholdingTaxCollected
    {
        get
        {
            return this.withholdingTaxCollectedField;
        }
        set
        {
            this.withholdingTaxCollectedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal changeInDividendAccruals
    {
        get
        {
            return this.changeInDividendAccrualsField;
        }
        set
        {
            this.changeInDividendAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal interest
    {
        get
        {
            return this.interestField;
        }
        set
        {
            this.interestField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal changeInInterestAccruals
    {
        get
        {
            return this.changeInInterestAccrualsField;
        }
        set
        {
            this.changeInInterestAccrualsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte advisorFees
    {
        get
        {
            return this.advisorFeesField;
        }
        set
        {
            this.advisorFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte clientFees
    {
        get
        {
            return this.clientFeesField;
        }
        set
        {
            this.clientFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal otherFees
    {
        get
        {
            return this.otherFeesField;
        }
        set
        {
            this.otherFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte feesReceivables
    {
        get
        {
            return this.feesReceivablesField;
        }
        set
        {
            this.feesReceivablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal commissions
    {
        get
        {
            return this.commissionsField;
        }
        set
        {
            this.commissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte commissionReceivables
    {
        get
        {
            return this.commissionReceivablesField;
        }
        set
        {
            this.commissionReceivablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte forexCommissions
    {
        get
        {
            return this.forexCommissionsField;
        }
        set
        {
            this.forexCommissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte transactionTax
    {
        get
        {
            return this.transactionTaxField;
        }
        set
        {
            this.transactionTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte taxReceivables
    {
        get
        {
            return this.taxReceivablesField;
        }
        set
        {
            this.taxReceivablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte salesTax
    {
        get
        {
            return this.salesTaxField;
        }
        set
        {
            this.salesTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte softDollars
    {
        get
        {
            return this.softDollarsField;
        }
        set
        {
            this.softDollarsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte netFxTrading
    {
        get
        {
            return this.netFxTradingField;
        }
        set
        {
            this.netFxTradingField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslation
    {
        get
        {
            return this.fxTranslationField;
        }
        set
        {
            this.fxTranslationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte linkingAdjustments
    {
        get
        {
            return this.linkingAdjustmentsField;
        }
        set
        {
            this.linkingAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endingValue
    {
        get
        {
            return this.endingValueField;
        }
        set
        {
            this.endingValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal twr
    {
        get
        {
            return this.twrField;
        }
        set
        {
            this.twrField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementMTMPerformanceSummaryUnderlying
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private string conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private string multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private string reportDateField;

    private string prevCloseQuantityField;

    private string prevClosePriceField;

    private string closeQuantityField;

    private string closePriceField;

    private decimal transactionMtmField;

    private decimal priorOpenMtmField;

    private decimal commissionsField;

    private decimal otherField;

    private decimal totalField;

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string prevCloseQuantity
    {
        get
        {
            return this.prevCloseQuantityField;
        }
        set
        {
            this.prevCloseQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string prevClosePrice
    {
        get
        {
            return this.prevClosePriceField;
        }
        set
        {
            this.prevClosePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string closeQuantity
    {
        get
        {
            return this.closeQuantityField;
        }
        set
        {
            this.closeQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string closePrice
    {
        get
        {
            return this.closePriceField;
        }
        set
        {
            this.closePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal transactionMtm
    {
        get
        {
            return this.transactionMtmField;
        }
        set
        {
            this.transactionMtmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal priorOpenMtm
    {
        get
        {
            return this.priorOpenMtmField;
        }
        set
        {
            this.priorOpenMtmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal commissions
    {
        get
        {
            return this.commissionsField;
        }
        set
        {
            this.commissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementCashReport
{

    private FlexQueryResponseFlexStatementsFlexStatementCashReportCashReportCurrency cashReportCurrencyField;

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementCashReportCashReportCurrency CashReportCurrency
    {
        get
        {
            return this.cashReportCurrencyField;
        }
        set
        {
            this.cashReportCurrencyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementCashReportCashReportCurrency
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private uint fromDateField;

    private uint toDateField;

    private decimal startingCashField;

    private decimal startingCashSecField;

    private byte startingCashComField;

    private byte clientFeesField;

    private byte clientFeesSecField;

    private byte clientFeesComField;

    private decimal commissionsField;

    private decimal commissionsSecField;

    private byte commissionsComField;

    private byte billableCommissionsField;

    private byte billableCommissionsSecField;

    private byte billableCommissionsComField;

    private ushort depositWithdrawalsField;

    private ushort depositWithdrawalsSecField;

    private byte depositWithdrawalsComField;

    private ushort depositsField;

    private ushort depositsSecField;

    private byte depositsComField;

    private byte withdrawalsField;

    private byte withdrawalsSecField;

    private byte withdrawalsComField;

    private byte accountTransfersField;

    private byte accountTransfersSecField;

    private byte accountTransfersComField;

    private byte linkingAdjustmentsField;

    private byte linkingAdjustmentsSecField;

    private byte linkingAdjustmentsComField;

    private byte internalTransfersField;

    private byte internalTransfersSecField;

    private byte internalTransfersComField;

    private decimal dividendsField;

    private decimal dividendsSecField;

    private byte dividendsComField;

    private byte insuredDepositInterestField;

    private byte insuredDepositInterestSecField;

    private byte insuredDepositInterestComField;

    private decimal brokerInterestField;

    private decimal brokerInterestSecField;

    private byte brokerInterestComField;

    private byte bondInterestField;

    private byte bondInterestSecField;

    private byte bondInterestComField;

    private byte cashSettlingMtmField;

    private byte cashSettlingMtmSecField;

    private byte cashSettlingMtmComField;

    private byte realizedVmField;

    private byte realizedVmSecField;

    private byte realizedVmComField;

    private byte cfdChargesField;

    private byte cfdChargesSecField;

    private byte cfdChargesComField;

    private ushort netTradesSalesField;

    private ushort netTradesSalesSecField;

    private byte netTradesSalesComField;

    private decimal netTradesPurchasesField;

    private decimal netTradesPurchasesSecField;

    private byte netTradesPurchasesComField;

    private byte advisorFeesField;

    private byte advisorFeesSecField;

    private byte advisorFeesComField;

    private byte feesReceivablesField;

    private byte feesReceivablesSecField;

    private byte feesReceivablesComField;

    private decimal paymentInLieuField;

    private decimal paymentInLieuSecField;

    private byte paymentInLieuComField;

    private byte transactionTaxField;

    private byte transactionTaxSecField;

    private byte transactionTaxComField;

    private byte taxReceivablesField;

    private byte taxReceivablesSecField;

    private byte taxReceivablesComField;

    private decimal withholdingTaxField;

    private decimal withholdingTaxSecField;

    private byte withholdingTaxComField;

    private byte withholding871mField;

    private byte withholding871mSecField;

    private byte withholding871mComField;

    private byte withholdingCollectedTaxField;

    private byte withholdingCollectedTaxSecField;

    private byte withholdingCollectedTaxComField;

    private byte salesTaxField;

    private byte salesTaxSecField;

    private byte salesTaxComField;

    private byte fxTranslationGainLossField;

    private byte fxTranslationGainLossSecField;

    private byte fxTranslationGainLossComField;

    private decimal otherFeesField;

    private decimal otherFeesSecField;

    private byte otherFeesComField;

    private byte otherField;

    private byte otherSecField;

    private byte otherComField;

    private decimal endingCashField;

    private decimal endingCashSecField;

    private byte endingCashComField;

    private decimal endingSettledCashField;

    private decimal endingSettledCashSecField;

    private byte endingSettledCashComField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint fromDate
    {
        get
        {
            return this.fromDateField;
        }
        set
        {
            this.fromDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint toDate
    {
        get
        {
            return this.toDateField;
        }
        set
        {
            this.toDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal startingCash
    {
        get
        {
            return this.startingCashField;
        }
        set
        {
            this.startingCashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal startingCashSec
    {
        get
        {
            return this.startingCashSecField;
        }
        set
        {
            this.startingCashSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte startingCashCom
    {
        get
        {
            return this.startingCashComField;
        }
        set
        {
            this.startingCashComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte clientFees
    {
        get
        {
            return this.clientFeesField;
        }
        set
        {
            this.clientFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte clientFeesSec
    {
        get
        {
            return this.clientFeesSecField;
        }
        set
        {
            this.clientFeesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte clientFeesCom
    {
        get
        {
            return this.clientFeesComField;
        }
        set
        {
            this.clientFeesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal commissions
    {
        get
        {
            return this.commissionsField;
        }
        set
        {
            this.commissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal commissionsSec
    {
        get
        {
            return this.commissionsSecField;
        }
        set
        {
            this.commissionsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte commissionsCom
    {
        get
        {
            return this.commissionsComField;
        }
        set
        {
            this.commissionsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte billableCommissions
    {
        get
        {
            return this.billableCommissionsField;
        }
        set
        {
            this.billableCommissionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte billableCommissionsSec
    {
        get
        {
            return this.billableCommissionsSecField;
        }
        set
        {
            this.billableCommissionsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte billableCommissionsCom
    {
        get
        {
            return this.billableCommissionsComField;
        }
        set
        {
            this.billableCommissionsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort depositWithdrawals
    {
        get
        {
            return this.depositWithdrawalsField;
        }
        set
        {
            this.depositWithdrawalsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort depositWithdrawalsSec
    {
        get
        {
            return this.depositWithdrawalsSecField;
        }
        set
        {
            this.depositWithdrawalsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte depositWithdrawalsCom
    {
        get
        {
            return this.depositWithdrawalsComField;
        }
        set
        {
            this.depositWithdrawalsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort deposits
    {
        get
        {
            return this.depositsField;
        }
        set
        {
            this.depositsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort depositsSec
    {
        get
        {
            return this.depositsSecField;
        }
        set
        {
            this.depositsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte depositsCom
    {
        get
        {
            return this.depositsComField;
        }
        set
        {
            this.depositsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withdrawals
    {
        get
        {
            return this.withdrawalsField;
        }
        set
        {
            this.withdrawalsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withdrawalsSec
    {
        get
        {
            return this.withdrawalsSecField;
        }
        set
        {
            this.withdrawalsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withdrawalsCom
    {
        get
        {
            return this.withdrawalsComField;
        }
        set
        {
            this.withdrawalsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte accountTransfers
    {
        get
        {
            return this.accountTransfersField;
        }
        set
        {
            this.accountTransfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte accountTransfersSec
    {
        get
        {
            return this.accountTransfersSecField;
        }
        set
        {
            this.accountTransfersSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte accountTransfersCom
    {
        get
        {
            return this.accountTransfersComField;
        }
        set
        {
            this.accountTransfersComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte linkingAdjustments
    {
        get
        {
            return this.linkingAdjustmentsField;
        }
        set
        {
            this.linkingAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte linkingAdjustmentsSec
    {
        get
        {
            return this.linkingAdjustmentsSecField;
        }
        set
        {
            this.linkingAdjustmentsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte linkingAdjustmentsCom
    {
        get
        {
            return this.linkingAdjustmentsComField;
        }
        set
        {
            this.linkingAdjustmentsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte internalTransfers
    {
        get
        {
            return this.internalTransfersField;
        }
        set
        {
            this.internalTransfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte internalTransfersSec
    {
        get
        {
            return this.internalTransfersSecField;
        }
        set
        {
            this.internalTransfersSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte internalTransfersCom
    {
        get
        {
            return this.internalTransfersComField;
        }
        set
        {
            this.internalTransfersComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal dividends
    {
        get
        {
            return this.dividendsField;
        }
        set
        {
            this.dividendsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal dividendsSec
    {
        get
        {
            return this.dividendsSecField;
        }
        set
        {
            this.dividendsSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte dividendsCom
    {
        get
        {
            return this.dividendsComField;
        }
        set
        {
            this.dividendsComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte insuredDepositInterest
    {
        get
        {
            return this.insuredDepositInterestField;
        }
        set
        {
            this.insuredDepositInterestField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte insuredDepositInterestSec
    {
        get
        {
            return this.insuredDepositInterestSecField;
        }
        set
        {
            this.insuredDepositInterestSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte insuredDepositInterestCom
    {
        get
        {
            return this.insuredDepositInterestComField;
        }
        set
        {
            this.insuredDepositInterestComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brokerInterest
    {
        get
        {
            return this.brokerInterestField;
        }
        set
        {
            this.brokerInterestField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brokerInterestSec
    {
        get
        {
            return this.brokerInterestSecField;
        }
        set
        {
            this.brokerInterestSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte brokerInterestCom
    {
        get
        {
            return this.brokerInterestComField;
        }
        set
        {
            this.brokerInterestComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bondInterest
    {
        get
        {
            return this.bondInterestField;
        }
        set
        {
            this.bondInterestField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bondInterestSec
    {
        get
        {
            return this.bondInterestSecField;
        }
        set
        {
            this.bondInterestSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte bondInterestCom
    {
        get
        {
            return this.bondInterestComField;
        }
        set
        {
            this.bondInterestComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cashSettlingMtm
    {
        get
        {
            return this.cashSettlingMtmField;
        }
        set
        {
            this.cashSettlingMtmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cashSettlingMtmSec
    {
        get
        {
            return this.cashSettlingMtmSecField;
        }
        set
        {
            this.cashSettlingMtmSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cashSettlingMtmCom
    {
        get
        {
            return this.cashSettlingMtmComField;
        }
        set
        {
            this.cashSettlingMtmComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte realizedVm
    {
        get
        {
            return this.realizedVmField;
        }
        set
        {
            this.realizedVmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte realizedVmSec
    {
        get
        {
            return this.realizedVmSecField;
        }
        set
        {
            this.realizedVmSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte realizedVmCom
    {
        get
        {
            return this.realizedVmComField;
        }
        set
        {
            this.realizedVmComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cfdCharges
    {
        get
        {
            return this.cfdChargesField;
        }
        set
        {
            this.cfdChargesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cfdChargesSec
    {
        get
        {
            return this.cfdChargesSecField;
        }
        set
        {
            this.cfdChargesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte cfdChargesCom
    {
        get
        {
            return this.cfdChargesComField;
        }
        set
        {
            this.cfdChargesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort netTradesSales
    {
        get
        {
            return this.netTradesSalesField;
        }
        set
        {
            this.netTradesSalesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort netTradesSalesSec
    {
        get
        {
            return this.netTradesSalesSecField;
        }
        set
        {
            this.netTradesSalesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte netTradesSalesCom
    {
        get
        {
            return this.netTradesSalesComField;
        }
        set
        {
            this.netTradesSalesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netTradesPurchases
    {
        get
        {
            return this.netTradesPurchasesField;
        }
        set
        {
            this.netTradesPurchasesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netTradesPurchasesSec
    {
        get
        {
            return this.netTradesPurchasesSecField;
        }
        set
        {
            this.netTradesPurchasesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte netTradesPurchasesCom
    {
        get
        {
            return this.netTradesPurchasesComField;
        }
        set
        {
            this.netTradesPurchasesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte advisorFees
    {
        get
        {
            return this.advisorFeesField;
        }
        set
        {
            this.advisorFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte advisorFeesSec
    {
        get
        {
            return this.advisorFeesSecField;
        }
        set
        {
            this.advisorFeesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte advisorFeesCom
    {
        get
        {
            return this.advisorFeesComField;
        }
        set
        {
            this.advisorFeesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte feesReceivables
    {
        get
        {
            return this.feesReceivablesField;
        }
        set
        {
            this.feesReceivablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte feesReceivablesSec
    {
        get
        {
            return this.feesReceivablesSecField;
        }
        set
        {
            this.feesReceivablesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte feesReceivablesCom
    {
        get
        {
            return this.feesReceivablesComField;
        }
        set
        {
            this.feesReceivablesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal paymentInLieu
    {
        get
        {
            return this.paymentInLieuField;
        }
        set
        {
            this.paymentInLieuField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal paymentInLieuSec
    {
        get
        {
            return this.paymentInLieuSecField;
        }
        set
        {
            this.paymentInLieuSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte paymentInLieuCom
    {
        get
        {
            return this.paymentInLieuComField;
        }
        set
        {
            this.paymentInLieuComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte transactionTax
    {
        get
        {
            return this.transactionTaxField;
        }
        set
        {
            this.transactionTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte transactionTaxSec
    {
        get
        {
            return this.transactionTaxSecField;
        }
        set
        {
            this.transactionTaxSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte transactionTaxCom
    {
        get
        {
            return this.transactionTaxComField;
        }
        set
        {
            this.transactionTaxComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte taxReceivables
    {
        get
        {
            return this.taxReceivablesField;
        }
        set
        {
            this.taxReceivablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte taxReceivablesSec
    {
        get
        {
            return this.taxReceivablesSecField;
        }
        set
        {
            this.taxReceivablesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte taxReceivablesCom
    {
        get
        {
            return this.taxReceivablesComField;
        }
        set
        {
            this.taxReceivablesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal withholdingTax
    {
        get
        {
            return this.withholdingTaxField;
        }
        set
        {
            this.withholdingTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal withholdingTaxSec
    {
        get
        {
            return this.withholdingTaxSecField;
        }
        set
        {
            this.withholdingTaxSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholdingTaxCom
    {
        get
        {
            return this.withholdingTaxComField;
        }
        set
        {
            this.withholdingTaxComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholding871m
    {
        get
        {
            return this.withholding871mField;
        }
        set
        {
            this.withholding871mField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholding871mSec
    {
        get
        {
            return this.withholding871mSecField;
        }
        set
        {
            this.withholding871mSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholding871mCom
    {
        get
        {
            return this.withholding871mComField;
        }
        set
        {
            this.withholding871mComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholdingCollectedTax
    {
        get
        {
            return this.withholdingCollectedTaxField;
        }
        set
        {
            this.withholdingCollectedTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholdingCollectedTaxSec
    {
        get
        {
            return this.withholdingCollectedTaxSecField;
        }
        set
        {
            this.withholdingCollectedTaxSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte withholdingCollectedTaxCom
    {
        get
        {
            return this.withholdingCollectedTaxComField;
        }
        set
        {
            this.withholdingCollectedTaxComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte salesTax
    {
        get
        {
            return this.salesTaxField;
        }
        set
        {
            this.salesTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte salesTaxSec
    {
        get
        {
            return this.salesTaxSecField;
        }
        set
        {
            this.salesTaxSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte salesTaxCom
    {
        get
        {
            return this.salesTaxComField;
        }
        set
        {
            this.salesTaxComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslationGainLoss
    {
        get
        {
            return this.fxTranslationGainLossField;
        }
        set
        {
            this.fxTranslationGainLossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslationGainLossSec
    {
        get
        {
            return this.fxTranslationGainLossSecField;
        }
        set
        {
            this.fxTranslationGainLossSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslationGainLossCom
    {
        get
        {
            return this.fxTranslationGainLossComField;
        }
        set
        {
            this.fxTranslationGainLossComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal otherFees
    {
        get
        {
            return this.otherFeesField;
        }
        set
        {
            this.otherFeesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal otherFeesSec
    {
        get
        {
            return this.otherFeesSecField;
        }
        set
        {
            this.otherFeesSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte otherFeesCom
    {
        get
        {
            return this.otherFeesComField;
        }
        set
        {
            this.otherFeesComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte otherSec
    {
        get
        {
            return this.otherSecField;
        }
        set
        {
            this.otherSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte otherCom
    {
        get
        {
            return this.otherComField;
        }
        set
        {
            this.otherComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endingCash
    {
        get
        {
            return this.endingCashField;
        }
        set
        {
            this.endingCashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endingCashSec
    {
        get
        {
            return this.endingCashSecField;
        }
        set
        {
            this.endingCashSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte endingCashCom
    {
        get
        {
            return this.endingCashComField;
        }
        set
        {
            this.endingCashComField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endingSettledCash
    {
        get
        {
            return this.endingSettledCashField;
        }
        set
        {
            this.endingSettledCashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endingSettledCashSec
    {
        get
        {
            return this.endingSettledCashSecField;
        }
        set
        {
            this.endingSettledCashSecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte endingSettledCashCom
    {
        get
        {
            return this.endingSettledCashComField;
        }
        set
        {
            this.endingSettledCashComField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementStatementOfFundsLine
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private string conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint reportDateField;

    private uint dateField;

    private string activityDescriptionField;

    private string tradeIDField;

    private string debitField;

    private string creditField;

    private decimal amountField;

    private decimal balanceField;

    private string buySellField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string activityDescription
    {
        get
        {
            return this.activityDescriptionField;
        }
        set
        {
            this.activityDescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tradeID
    {
        get
        {
            return this.tradeIDField;
        }
        set
        {
            this.tradeIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string debit
    {
        get
        {
            return this.debitField;
        }
        set
        {
            this.debitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string credit
    {
        get
        {
            return this.creditField;
        }
        set
        {
            this.creditField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal balance
    {
        get
        {
            return this.balanceField;
        }
        set
        {
            this.balanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string buySell
    {
        get
        {
            return this.buySellField;
        }
        set
        {
            this.buySellField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementChangeInPositionValue
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private string assetCategoryField;

    private decimal priorPeriodValueField;

    private decimal transactionsField;

    private decimal mtmPriorPeriodPositionsField;

    private decimal mtmTransactionsField;

    private byte corporateActionsField;

    private byte otherField;

    private byte accountTransfersField;

    private byte linkingAdjustmentsField;

    private byte fxTranslationPnlField;

    private byte futurePriceAdjustmentsField;

    private byte settledCashField;

    private decimal endOfPeriodValueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal priorPeriodValue
    {
        get
        {
            return this.priorPeriodValueField;
        }
        set
        {
            this.priorPeriodValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal transactions
    {
        get
        {
            return this.transactionsField;
        }
        set
        {
            this.transactionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal mtmPriorPeriodPositions
    {
        get
        {
            return this.mtmPriorPeriodPositionsField;
        }
        set
        {
            this.mtmPriorPeriodPositionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal mtmTransactions
    {
        get
        {
            return this.mtmTransactionsField;
        }
        set
        {
            this.mtmTransactionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte corporateActions
    {
        get
        {
            return this.corporateActionsField;
        }
        set
        {
            this.corporateActionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte accountTransfers
    {
        get
        {
            return this.accountTransfersField;
        }
        set
        {
            this.accountTransfersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte linkingAdjustments
    {
        get
        {
            return this.linkingAdjustmentsField;
        }
        set
        {
            this.linkingAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslationPnl
    {
        get
        {
            return this.fxTranslationPnlField;
        }
        set
        {
            this.fxTranslationPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte futurePriceAdjustments
    {
        get
        {
            return this.futurePriceAdjustmentsField;
        }
        set
        {
            this.futurePriceAdjustmentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte settledCash
    {
        get
        {
            return this.settledCashField;
        }
        set
        {
            this.settledCashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal endOfPeriodValue
    {
        get
        {
            return this.endOfPeriodValueField;
        }
        set
        {
            this.endOfPeriodValueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementTrade
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint tradeIDField;

    private uint reportDateField;

    private uint tradeDateField;

    private uint tradeTimeField;

    private uint settleDateTargetField;

    private string transactionTypeField;

    private string exchangeField;

    private short quantityField;

    private decimal tradePriceField;

    private decimal tradeMoneyField;

    private decimal proceedsField;

    private byte taxesField;

    private decimal ibCommissionField;

    private string ibCommissionCurrencyField;

    private decimal netCashField;

    private decimal closePriceField;

    private string openCloseIndicatorField;

    private string notesField;

    private decimal costField;

    private byte fifoPnlRealizedField;

    private byte fxPnlField;

    private decimal mtmPnlField;

    private byte origTradePriceField;

    private string origTradeDateField;

    private string origTradeIDField;

    private byte origOrderIDField;

    private string clearingFirmIDField;

    private ulong transactionIDField;

    private string buySellField;

    private ulong ibOrderIDField;

    private string ibExecIDField;

    private string brokerageOrderIDField;

    private string orderReferenceField;

    private string volatilityOrderLinkField;

    private string exchOrderIdField;

    private string extExecIDField;

    private string orderTimeField;

    private string openDateTimeField;

    private string holdingPeriodDateTimeField;

    private string whenRealizedField;

    private string whenReopenedField;

    private string levelOfDetailField;

    private byte changeInPriceField;

    private byte changeInQuantityField;

    private string orderTypeField;

    private string traderIDField;

    private string isAPIOrderField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint tradeID
    {
        get
        {
            return this.tradeIDField;
        }
        set
        {
            this.tradeIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint tradeDate
    {
        get
        {
            return this.tradeDateField;
        }
        set
        {
            this.tradeDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint tradeTime
    {
        get
        {
            return this.tradeTimeField;
        }
        set
        {
            this.tradeTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint settleDateTarget
    {
        get
        {
            return this.settleDateTargetField;
        }
        set
        {
            this.settleDateTargetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string exchange
    {
        get
        {
            return this.exchangeField;
        }
        set
        {
            this.exchangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tradePrice
    {
        get
        {
            return this.tradePriceField;
        }
        set
        {
            this.tradePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tradeMoney
    {
        get
        {
            return this.tradeMoneyField;
        }
        set
        {
            this.tradeMoneyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal proceeds
    {
        get
        {
            return this.proceedsField;
        }
        set
        {
            this.proceedsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte taxes
    {
        get
        {
            return this.taxesField;
        }
        set
        {
            this.taxesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ibCommission
    {
        get
        {
            return this.ibCommissionField;
        }
        set
        {
            this.ibCommissionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ibCommissionCurrency
    {
        get
        {
            return this.ibCommissionCurrencyField;
        }
        set
        {
            this.ibCommissionCurrencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netCash
    {
        get
        {
            return this.netCashField;
        }
        set
        {
            this.netCashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal closePrice
    {
        get
        {
            return this.closePriceField;
        }
        set
        {
            this.closePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string openCloseIndicator
    {
        get
        {
            return this.openCloseIndicatorField;
        }
        set
        {
            this.openCloseIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cost
    {
        get
        {
            return this.costField;
        }
        set
        {
            this.costField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fifoPnlRealized
    {
        get
        {
            return this.fifoPnlRealizedField;
        }
        set
        {
            this.fifoPnlRealizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxPnl
    {
        get
        {
            return this.fxPnlField;
        }
        set
        {
            this.fxPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal mtmPnl
    {
        get
        {
            return this.mtmPnlField;
        }
        set
        {
            this.mtmPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte origTradePrice
    {
        get
        {
            return this.origTradePriceField;
        }
        set
        {
            this.origTradePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string origTradeDate
    {
        get
        {
            return this.origTradeDateField;
        }
        set
        {
            this.origTradeDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string origTradeID
    {
        get
        {
            return this.origTradeIDField;
        }
        set
        {
            this.origTradeIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte origOrderID
    {
        get
        {
            return this.origOrderIDField;
        }
        set
        {
            this.origOrderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string clearingFirmID
    {
        get
        {
            return this.clearingFirmIDField;
        }
        set
        {
            this.clearingFirmIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong transactionID
    {
        get
        {
            return this.transactionIDField;
        }
        set
        {
            this.transactionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string buySell
    {
        get
        {
            return this.buySellField;
        }
        set
        {
            this.buySellField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong ibOrderID
    {
        get
        {
            return this.ibOrderIDField;
        }
        set
        {
            this.ibOrderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ibExecID
    {
        get
        {
            return this.ibExecIDField;
        }
        set
        {
            this.ibExecIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string brokerageOrderID
    {
        get
        {
            return this.brokerageOrderIDField;
        }
        set
        {
            this.brokerageOrderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string orderReference
    {
        get
        {
            return this.orderReferenceField;
        }
        set
        {
            this.orderReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string volatilityOrderLink
    {
        get
        {
            return this.volatilityOrderLinkField;
        }
        set
        {
            this.volatilityOrderLinkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string exchOrderId
    {
        get
        {
            return this.exchOrderIdField;
        }
        set
        {
            this.exchOrderIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extExecID
    {
        get
        {
            return this.extExecIDField;
        }
        set
        {
            this.extExecIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string orderTime
    {
        get
        {
            return this.orderTimeField;
        }
        set
        {
            this.orderTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string openDateTime
    {
        get
        {
            return this.openDateTimeField;
        }
        set
        {
            this.openDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string holdingPeriodDateTime
    {
        get
        {
            return this.holdingPeriodDateTimeField;
        }
        set
        {
            this.holdingPeriodDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string whenRealized
    {
        get
        {
            return this.whenRealizedField;
        }
        set
        {
            this.whenRealizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string whenReopened
    {
        get
        {
            return this.whenReopenedField;
        }
        set
        {
            this.whenReopenedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string levelOfDetail
    {
        get
        {
            return this.levelOfDetailField;
        }
        set
        {
            this.levelOfDetailField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte changeInPrice
    {
        get
        {
            return this.changeInPriceField;
        }
        set
        {
            this.changeInPriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte changeInQuantity
    {
        get
        {
            return this.changeInQuantityField;
        }
        set
        {
            this.changeInQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string orderType
    {
        get
        {
            return this.orderTypeField;
        }
        set
        {
            this.orderTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string traderID
    {
        get
        {
            return this.traderIDField;
        }
        set
        {
            this.traderIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isAPIOrder
    {
        get
        {
            return this.isAPIOrderField;
        }
        set
        {
            this.isAPIOrderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementOptionEAE
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint dateField;

    private string transactionTypeField;

    private short quantityField;

    private decimal tradePriceField;

    private decimal markPriceField;

    private string proceedsField;

    private decimal commisionsAndTaxField;

    private string costBasisField;

    private decimal realizedPnlField;

    private decimal fxPnlField;

    private decimal mtmPnlField;

    private uint tradeIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tradePrice
    {
        get
        {
            return this.tradePriceField;
        }
        set
        {
            this.tradePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal markPrice
    {
        get
        {
            return this.markPriceField;
        }
        set
        {
            this.markPriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string proceeds
    {
        get
        {
            return this.proceedsField;
        }
        set
        {
            this.proceedsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal commisionsAndTax
    {
        get
        {
            return this.commisionsAndTaxField;
        }
        set
        {
            this.commisionsAndTaxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string costBasis
    {
        get
        {
            return this.costBasisField;
        }
        set
        {
            this.costBasisField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal realizedPnl
    {
        get
        {
            return this.realizedPnlField;
        }
        set
        {
            this.realizedPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal fxPnl
    {
        get
        {
            return this.fxPnlField;
        }
        set
        {
            this.fxPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal mtmPnl
    {
        get
        {
            return this.mtmPnlField;
        }
        set
        {
            this.mtmPnlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint tradeID
    {
        get
        {
            return this.tradeIDField;
        }
        set
        {
            this.tradeIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementUnbundledCommissionDetail
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private string dateTimeField;

    private string exchangeField;

    private string buySellField;

    private short quantityField;

    private decimal priceField;

    private uint tradeIDField;

    private string orderReferenceField;

    private decimal totalCommissionField;

    private decimal brokerExecutionChargeField;

    private decimal brokerClearingChargeField;

    private decimal thirdPartyExecutionChargeField;

    private decimal thirdPartyClearingChargeField;

    private decimal thirdPartyRegulatoryChargeField;

    private byte otherField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string dateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string exchange
    {
        get
        {
            return this.exchangeField;
        }
        set
        {
            this.exchangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string buySell
    {
        get
        {
            return this.buySellField;
        }
        set
        {
            this.buySellField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint tradeID
    {
        get
        {
            return this.tradeIDField;
        }
        set
        {
            this.tradeIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string orderReference
    {
        get
        {
            return this.orderReferenceField;
        }
        set
        {
            this.orderReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal totalCommission
    {
        get
        {
            return this.totalCommissionField;
        }
        set
        {
            this.totalCommissionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brokerExecutionCharge
    {
        get
        {
            return this.brokerExecutionChargeField;
        }
        set
        {
            this.brokerExecutionChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal brokerClearingCharge
    {
        get
        {
            return this.brokerClearingChargeField;
        }
        set
        {
            this.brokerClearingChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal thirdPartyExecutionCharge
    {
        get
        {
            return this.thirdPartyExecutionChargeField;
        }
        set
        {
            this.thirdPartyExecutionChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal thirdPartyClearingCharge
    {
        get
        {
            return this.thirdPartyClearingChargeField;
        }
        set
        {
            this.thirdPartyClearingChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal thirdPartyRegulatoryCharge
    {
        get
        {
            return this.thirdPartyRegulatoryChargeField;
        }
        set
        {
            this.thirdPartyRegulatoryChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementPriorPeriodPosition
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint dateField;

    private decimal priceField;

    private decimal priorMtmPnlField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal priorMtmPnl
    {
        get
        {
            return this.priorMtmPnlField;
        }
        set
        {
            this.priorMtmPnlField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementCashTransaction
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private string conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint dateTimeField;

    private decimal amountField;

    private string typeField;

    private string tradeIDField;

    private string codeField;

    private ulong transactionIDField;

    private uint reportDateField;

    private string clientReferenceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint dateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tradeID
    {
        get
        {
            return this.tradeIDField;
        }
        set
        {
            this.tradeIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong transactionID
    {
        get
        {
            return this.transactionIDField;
        }
        set
        {
            this.transactionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string clientReference
    {
        get
        {
            return this.clientReferenceField;
        }
        set
        {
            this.clientReferenceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementInterestAccruals
{

    private FlexQueryResponseFlexStatementsFlexStatementInterestAccrualsInterestAccrualsCurrency interestAccrualsCurrencyField;

    /// <remarks/>
    public FlexQueryResponseFlexStatementsFlexStatementInterestAccrualsInterestAccrualsCurrency InterestAccrualsCurrency
    {
        get
        {
            return this.interestAccrualsCurrencyField;
        }
        set
        {
            this.interestAccrualsCurrencyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementInterestAccrualsInterestAccrualsCurrency
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private uint fromDateField;

    private uint toDateField;

    private decimal startingAccrualBalanceField;

    private decimal interestAccruedField;

    private decimal accrualReversalField;

    private byte fxTranslationField;

    private byte endingAccrualBalanceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint fromDate
    {
        get
        {
            return this.fromDateField;
        }
        set
        {
            this.fromDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint toDate
    {
        get
        {
            return this.toDateField;
        }
        set
        {
            this.toDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal startingAccrualBalance
    {
        get
        {
            return this.startingAccrualBalanceField;
        }
        set
        {
            this.startingAccrualBalanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal interestAccrued
    {
        get
        {
            return this.interestAccruedField;
        }
        set
        {
            this.interestAccruedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal accrualReversal
    {
        get
        {
            return this.accrualReversalField;
        }
        set
        {
            this.accrualReversalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxTranslation
    {
        get
        {
            return this.fxTranslationField;
        }
        set
        {
            this.fxTranslationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte endingAccrualBalance
    {
        get
        {
            return this.endingAccrualBalanceField;
        }
        set
        {
            this.endingAccrualBalanceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementChangeInDividendAccrual
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint dateField;

    private uint exDateField;

    private uint payDateField;

    private ushort quantityField;

    private decimal taxField;

    private decimal feeField;

    private decimal grossRateField;

    private decimal grossAmountField;

    private decimal netAmountField;

    private string codeField;

    private string fromAcctField;

    private string toAcctField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint exDate
    {
        get
        {
            return this.exDateField;
        }
        set
        {
            this.exDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint payDate
    {
        get
        {
            return this.payDateField;
        }
        set
        {
            this.payDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal tax
    {
        get
        {
            return this.taxField;
        }
        set
        {
            this.taxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal fee
    {
        get
        {
            return this.feeField;
        }
        set
        {
            this.feeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal grossRate
    {
        get
        {
            return this.grossRateField;
        }
        set
        {
            this.grossRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal grossAmount
    {
        get
        {
            return this.grossAmountField;
        }
        set
        {
            this.grossAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netAmount
    {
        get
        {
            return this.netAmountField;
        }
        set
        {
            this.netAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fromAcct
    {
        get
        {
            return this.fromAcctField;
        }
        set
        {
            this.fromAcctField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string toAcct
    {
        get
        {
            return this.toAcctField;
        }
        set
        {
            this.toAcctField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementOpenDividendAccrual
{

    private string accountIdField;

    private string acctAliasField;

    private string modelField;

    private string currencyField;

    private byte fxRateToBaseField;

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private string principalAdjustFactorField;

    private uint exDateField;

    private uint payDateField;

    private byte quantityField;

    private byte taxField;

    private decimal feeField;

    private decimal grossRateField;

    private decimal grossAmountField;

    private decimal netAmountField;

    private string codeField;

    private string fromAcctField;

    private string toAcctField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string accountId
    {
        get
        {
            return this.accountIdField;
        }
        set
        {
            this.accountIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string acctAlias
    {
        get
        {
            return this.acctAliasField;
        }
        set
        {
            this.acctAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte fxRateToBase
    {
        get
        {
            return this.fxRateToBaseField;
        }
        set
        {
            this.fxRateToBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint exDate
    {
        get
        {
            return this.exDateField;
        }
        set
        {
            this.exDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint payDate
    {
        get
        {
            return this.payDateField;
        }
        set
        {
            this.payDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tax
    {
        get
        {
            return this.taxField;
        }
        set
        {
            this.taxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal fee
    {
        get
        {
            return this.feeField;
        }
        set
        {
            this.feeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal grossRate
    {
        get
        {
            return this.grossRateField;
        }
        set
        {
            this.grossRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal grossAmount
    {
        get
        {
            return this.grossAmountField;
        }
        set
        {
            this.grossAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netAmount
    {
        get
        {
            return this.netAmountField;
        }
        set
        {
            this.netAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fromAcct
    {
        get
        {
            return this.fromAcctField;
        }
        set
        {
            this.fromAcctField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string toAcct
    {
        get
        {
            return this.toAcctField;
        }
        set
        {
            this.toAcctField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FlexQueryResponseFlexStatementsFlexStatementSecurityInfo
{

    private string assetCategoryField;

    private string symbolField;

    private string descriptionField;

    private uint conidField;

    private string securityIDField;

    private string securityIDTypeField;

    private string cusipField;

    private string isinField;

    private string underlyingConidField;

    private string underlyingSymbolField;

    private string issuerField;

    private byte multiplierField;

    private string strikeField;

    private string expiryField;

    private string putCallField;

    private byte principalAdjustFactorField;

    private string maturityField;

    private string issueDateField;

    private string underlyingCategoryField;

    private string subCategoryField;

    private string listingExchangeField;

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assetCategory
    {
        get
        {
            return this.assetCategoryField;
        }
        set
        {
            this.assetCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint conid
    {
        get
        {
            return this.conidField;
        }
        set
        {
            this.conidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityID
    {
        get
        {
            return this.securityIDField;
        }
        set
        {
            this.securityIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string securityIDType
    {
        get
        {
            return this.securityIDTypeField;
        }
        set
        {
            this.securityIDTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingConid
    {
        get
        {
            return this.underlyingConidField;
        }
        set
        {
            this.underlyingConidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingSymbol
    {
        get
        {
            return this.underlyingSymbolField;
        }
        set
        {
            this.underlyingSymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte multiplier
    {
        get
        {
            return this.multiplierField;
        }
        set
        {
            this.multiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string strike
    {
        get
        {
            return this.strikeField;
        }
        set
        {
            this.strikeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expiry
    {
        get
        {
            return this.expiryField;
        }
        set
        {
            this.expiryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string putCall
    {
        get
        {
            return this.putCallField;
        }
        set
        {
            this.putCallField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte principalAdjustFactor
    {
        get
        {
            return this.principalAdjustFactorField;
        }
        set
        {
            this.principalAdjustFactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string maturity
    {
        get
        {
            return this.maturityField;
        }
        set
        {
            this.maturityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string underlyingCategory
    {
        get
        {
            return this.underlyingCategoryField;
        }
        set
        {
            this.underlyingCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string subCategory
    {
        get
        {
            return this.subCategoryField;
        }
        set
        {
            this.subCategoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string listingExchange
    {
        get
        {
            return this.listingExchangeField;
        }
        set
        {
            this.listingExchangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}


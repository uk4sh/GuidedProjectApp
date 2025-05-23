using Library.ApplicationCore;
using Library.ApplicationCore.Entities;

namespace Library.Infrastructure.Data;

public class JsonLoanRepository : ILoanRepository
{
    private readonly JsonData _jsonData;

    public JsonLoanRepository(JsonData jsonData)
    {
        _jsonData = jsonData;
    }

    public async Task<Loan?> GetLoan(int id)
    {
        await _jsonData.EnsureDataLoaded();

        var loan = _jsonData.Loans!.FirstOrDefault(l => l.Id == id);
        return loan != null ? _jsonData.GetPopulatedLoan(loan) : null;
    }

    public async Task UpdateLoan(Loan loan)
    {
        var existingLoan = _jsonData.Loans!.FirstOrDefault(l => l.Id == loan.Id);

        if (existingLoan != null)
        {
            existingLoan.BookItemId = loan.BookItemId;
            existingLoan.PatronId = loan.PatronId;
            existingLoan.LoanDate = loan.LoanDate;
            existingLoan.DueDate = loan.DueDate;
            existingLoan.ReturnDate = loan.ReturnDate;

            await _jsonData.SaveLoans(_jsonData.Loans!);

            await _jsonData.LoadData();
        }
    }
}
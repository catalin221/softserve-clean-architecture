using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Infrastracture.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Borrowing, BorrowingDTO>();
    }
}

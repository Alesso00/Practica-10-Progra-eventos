using CommonLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class StudentsValidator : AbstractValidator<Student>
    {
        public StudentsValidator() 
        {
            RuleFor(student => student.name).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El nombre no puede estar vacio")
                    .MinimumLength(2).WithMessage("El nombre debe tener minimo 2 letras");

            RuleFor(student => student.code).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El codigo no puede estar vacio")
                    .MinimumLength(9).WithMessage("El codigo debe tener minimo 9 caracteres");

            RuleFor(student => student.numberphone).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("El numero de telefono no puede estar vacio")
                    .MinimumLength(7).WithMessage("El numero de telefono debe tener minimo 7 numeros");

            RuleFor(student => student.city).Cascade(CascadeMode.Stop).NotEmpty().WithMessage("La ciudad no puede estar vacio")
                    .MinimumLength(2).WithMessage("La ciudad debe tener minimo 2 letras");
        }
    }
}

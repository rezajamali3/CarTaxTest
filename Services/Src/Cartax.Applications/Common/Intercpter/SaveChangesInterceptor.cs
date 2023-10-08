using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using IInterceptor = Castle.DynamicProxy.IInterceptor;




namespace Cartax.Applications.Common.Intercpter
{
    public abstract class SaveChangesInterceptor : ISaveChangesInterceptor, IInterceptor
    {

        private readonly IMediator _mediator;

        public SaveChangesInterceptor(IMediator mediator)
        {
            _mediator = mediator;
        }

     

        public void Intercept(IInvocation invocation)
        {
            // کد قبل از ذخیره تغییرات را اجرا کنید

            invocation.Proceed();

            // کد پس از ذخیره تغییرات را اجرا کنید
        }

        public async Task SavingChangesAsync(String context, CancellationToken cancellationToken = default)
        {
            
            // کد قبل از ذخیره تغییرات را اجرا کنید

            //await _mediator.Publish(new BeforeSaveChangesEvent(), cancellationToken);

         //   await context.SaveChangesAsync(cancellationToken);

            //await _mediator.Publish(new AfterSaveChangesEvent(), cancellationToken);

            // کد پس از ذخیره تغییرات را اجرا کنید

        }
    }
}

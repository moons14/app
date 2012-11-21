﻿using System;
using System.Data;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  public class CalculatorSpecs
  {
    public abstract class concern : Observes<Calculator>
    {
      
    }
    public class when_adding_two_positive_numbers : concern
    {
      //arrange
      Establish c = () =>
      {
        connection = depends.on<IDbConnection>();
      };

      //act
      Because b = () =>
        result = sut.add(2, 3);

      //assert
      It should_return_the_sum = () =>
        result.ShouldEqual(5);

      It should_open_a_connection_to_the_database = () =>
        connection.received(x => x.Open());

      static int result;
      static IDbConnection connection;
    } 

    public class when_attempting_to_add_a_negative_to_a_positive : concern
    {
      Because b = () =>
        spec.catch_exception(() => sut.add(2, -3));

      It should_throw_an_argument_exception = () =>
        spec.exception_thrown.ShouldBeAn<ArgumentException>();
    } 
  }
}
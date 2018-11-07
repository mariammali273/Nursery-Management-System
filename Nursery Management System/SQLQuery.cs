﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nursery_Management_System
{
    class SQLQuery
    {
        public SQLQuery() { }

        public void insertChildData(Child child)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertChildData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@childName", child.firstName);
            mCommand.Parameters.AddWithValue("@parentID", child.parentID);
            mCommand.Parameters.AddWithValue("@DOB", child.DOB);
            mCommand.Parameters.AddWithValue("@gender", child.gender);
            mCommand.Parameters.AddWithValue("@picture", child.image);
            mCommand.Parameters.AddWithValue("@roomID", child.roomID);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertParentData(Parent parent)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertParentData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@parentID", parent.id);
            mCommand.Parameters.AddWithValue("@parentFirstName", parent.firstName);
            mCommand.Parameters.AddWithValue("@parentLastName", parent.lastName);
            mCommand.Parameters.AddWithValue("@parentAddress", parent.address);
            mCommand.Parameters.AddWithValue("@parentPhoneNumber", parent.phoneNumber);
            mCommand.Parameters.AddWithValue("@parentCreditCard", parent.creditCard);
            mCommand.Parameters.AddWithValue("@parentEmail", parent.email);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertStaffData(Staff staff, string department)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertStaffData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@staffID", staff.id);
            mCommand.Parameters.AddWithValue("@staffFirstName", staff.firstName);
            mCommand.Parameters.AddWithValue("@staffLasttName", staff.lastName);
            mCommand.Parameters.AddWithValue("@staffPhoneNumber", staff.phoneNumber);
            mCommand.Parameters.AddWithValue("@staffEmail", staff.email);
            mCommand.Parameters.AddWithValue("@staffSalary", staff.salary);
            mCommand.Parameters.AddWithValue("@staffType", department);

            mSQL.insertQuery(mCommand);

            return;
        }

        public void insertRoomData(Room room)
        {
            SQL mSQL = new SQL();
            SqlCommand mCommand = new SqlCommand("insertRoomData");
            mCommand.CommandType = CommandType.StoredProcedure;

            mCommand.Parameters.AddWithValue("@roomNumber", room.number);
            if (room.staffID == -1)
                mCommand.Parameters.AddWithValue("@roomStaffID", DBNull.Value);
            else
                mCommand.Parameters.AddWithValue("@roomStaffID", room.staffID);
            mSQL.insertQuery(mCommand);

            return;
        }

        /*public LinkedList<Child> getChildByID(string query)
        {
            SQL sql = new SQL();

            DataTable dt = new DataTable();
            dt = sql.retrieveQuery(query);


            LinkedList<ChildClass> ccc = new LinkedList<ChildClass>();
            foreach(DataRow dr in dt.Rows)
            {
                ChildClass cs = new ChildClass();
                
                fillAll Data of cs from dt;

                ccc.AddAfter(cs);
            }
            
            return ccc;
        }*/

        public LinkedList<Child> getChildByParentID(string query)
        {
            LinkedList<Child> child = new LinkedList<Child>();
            return child;
        }

        public LinkedList<Child> getChildByRoomID(string query)
        {
            LinkedList<Child> child = new LinkedList<Child>();
            return child;
        }

        public LinkedList<Child> getPendingChildByParentID(string query)
        {
            LinkedList<Child> child = new LinkedList<Child>();
            return child;
        }

        public LinkedList<Parent> getParentByID(string query)
        {
            LinkedList<Parent> parent = new LinkedList<Parent>();
            return parent;
        }

        public LinkedList<Parent> getPendingParent(string query)
        {
            LinkedList<Parent> parent = new LinkedList<Parent>();
            return parent;
        }

        public LinkedList<Staff> getStaffByID(string query)
        {
            LinkedList<Staff> staff = new LinkedList<Staff>();
            return staff;
        }

        public LinkedList<Staff> getPendingStaff(string query)
        {
            LinkedList<Staff> staff = new LinkedList<Staff>();
            return staff;
        }

        public LinkedList<Staff> getStaffByType(string query)
        {
            LinkedList<Staff> staff = new LinkedList<Staff>();
            return staff;
        }

        public LinkedList<Staff> getStaffByRoomID(string query)
        {
            LinkedList<Staff> staff = new LinkedList<Staff>();
            return staff;
        }

        public LinkedList<Room> getRoomByID(string query)
        {
            LinkedList<Room> room = new LinkedList<Room>();
            return room;
        }

        public LinkedList<Room> getRoomByStaffID(string query)
        {
            LinkedList<Room> room = new LinkedList<Room>();
            return room;
        }

        public void updateChildData()
        {

        }

        public void updateParentData()
        {

        }

        public void updateStaffData()
        {
            
        }
        public void updateRoomData()
        {

        }

        public void deleteChildData()
        {

        }

        public void deleteParentData()
        {

        }

        public void deleteStaffData()
        {

        }
        public void deleteRoomData()
        {

        }
    }
}
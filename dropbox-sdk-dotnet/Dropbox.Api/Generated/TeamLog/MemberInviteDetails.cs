// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Invited a user to join the team.</para>
    /// </summary>
    public class MemberInviteDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberInviteDetails> Encoder = new MemberInviteDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberInviteDetails> Decoder = new MemberInviteDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberInviteDetails" />
        /// class.</para>
        /// </summary>
        public MemberInviteDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberInviteDetails" />.</para>
        /// </summary>
        private class MemberInviteDetailsEncoder : enc.StructEncoder<MemberInviteDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberInviteDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberInviteDetails" />.</para>
        /// </summary>
        private class MemberInviteDetailsDecoder : enc.StructDecoder<MemberInviteDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberInviteDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberInviteDetails Create()
            {
                return new MemberInviteDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberInviteDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
